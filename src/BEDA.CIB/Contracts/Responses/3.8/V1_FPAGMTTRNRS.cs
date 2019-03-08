using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.8.4理财产品说明书及协议查询响应主体
    /// </summary>
    public class V1_FPAGMTTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.4理财产品说明书及协议查询响应主体
        /// </summary>
        public FPAGMTTRNRS FPAGMTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.4理财产品说明书及协议查询响应主体
    /// </summary>
    public class FPAGMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.4理财产品说明书及协议查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPAGMTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.4理财产品说明书及协议查询响应内容
    /// </summary>
    public class FPAGMTTRN_RSBODY
    {
        /// <summary>
        /// 产品代码，8位
        /// </summary>
        [XmlElement(Order = 0)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 产品名称，最长50位
        /// </summary>
        [XmlElement(Order = 1)]
        public string PRODNAME { get; set; }
        /// <summary>
        /// 与协议对应的序列号（CIBLCCPxxx）,最长20位
        /// </summary>
        [XmlElement(Order = 2)]
        public string AGRM { get; set; }
        /// <summary>
        /// 协议书，base64编码后内容，解码范例请参考附件。如需保存在数据库，请建立大文本字段保存此节点内容。
        /// </summary>
        [XmlElement(Order = 3)]
        public string BASE64CONTENT { get; set; }
    }
}
