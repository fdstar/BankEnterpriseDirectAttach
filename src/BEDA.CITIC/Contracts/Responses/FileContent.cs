using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 中信银行返回的压缩过的文件内容
    /// </summary>
    public class FileContent
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlText]
        public string Value { get; set; }
        /// <summary>
        /// 将压缩过的银行字符串转化成可读的字符串
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string GetContent(Encoding encoding = null)
        {
            if (!string.IsNullOrWhiteSpace(this.Value))
            {
                var content = (encoding ?? Encoding.GetEncoding("GB18030"))
                    .GetString(GZipHelper.Decompress(Convert.FromBase64String(this.Value)));
                return content;
            }
            return null;
        }
    }
}
