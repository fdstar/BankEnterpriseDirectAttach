using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.5.2定活互转智能通知存款协议查询响应主体
    /// </summary>
    public class V1_ICAGMTTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.5.2定活互转智能通知存款协议查询响应主体
        /// </summary>
        public ICAGMTTRNRS ICAGMTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.5.2定活互转智能通知存款协议查询响应主体
    /// </summary>
    public class ICAGMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.5.2定活互转智能通知存款协议查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ICAGMTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.5.2定活互转智能通知存款协议查询响应内容
    /// </summary>
    public class ICAGMTTRN_RSBODY
    {
        /// <summary>
        /// 协议书内容，BASE64编码后内容，解码范例请参见附录。如需保存在数据库，请建立大文本字段保存此节点内容。	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string BASE64CONTENT { get; set; }
        /// <summary>
        /// 获取<see cref="BASE64CONTENT"/>解码后的内容
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string GetContent(string encoding = "GBK")
        {
            if (!string.IsNullOrWhiteSpace(this.BASE64CONTENT))
            {
                return Encoding.GetEncoding(encoding).GetString(Convert.FromBase64String(this.BASE64CONTENT));
            }
            return null;
        }
    }
}
