using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BEDA.Utils
{
    /// <summary>
    /// xml序列化帮助类
    /// </summary>
    public static class XmlHelper
    {
        /// <summary>
        /// xml序列化
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="obj">待序列化对象</param>
        /// <param name="encoding">字符编码，不指定则utf-8</param>
        /// <param name="showDeclaration">是否显示xml声明</param>
        /// <param name="removeDefaultNameSpace">是否移除默认的xmlns:xsi命名空间（注：如果待序列化对象指定了NameSpace还是会序列化出对应的命名空间）</param>
        /// <returns></returns>
        public static string Serializer<T>(this T obj, Encoding encoding = null, bool showDeclaration = true, bool removeDefaultNameSpace = false)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            using (MemoryStream stream = new MemoryStream())
            {
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.Indent = true;
                xws.OmitXmlDeclaration = !showDeclaration;
                xws.Encoding = encoding;
                using (XmlWriter xtw = XmlWriter.Create(stream, xws))
                {
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    if (removeDefaultNameSpace)
                    {
                        ns.Add("", "");
                    }
                    serializer.Serialize(xtw, obj, ns);
                    string xml = encoding.GetString(stream.GetBuffer());
                    if (xml[0] != '<')
                    {
                        var sIdx = xml.IndexOf('<');
                        var eIdx = xml.LastIndexOf('>');
                        xml = xml.Substring(sIdx, eIdx - sIdx + 1);
                        //return Regex.Replace(xml, @"^[\s\S]*?(?=<)|[^>]*?$", string.Empty);//正则存在性能问题
                    }
                    return xml;
                }
            }
        }
        /// <summary>
        /// xml反序列化
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="xml">序列化后的xml</param>
        /// <param name="throwException">反序列化异常时是否抛出异常</param>
        /// <returns></returns>
        public static T Deserialize<T>(this string xml, bool throwException = false)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                try
                {
                    return (T)serializer.Deserialize(sr);
                }
                catch
#if DEBUG
                (Exception ex)
#endif
                {
                    if (throwException) throw;
                    return default(T);
                }
            }
        }
    }
}
