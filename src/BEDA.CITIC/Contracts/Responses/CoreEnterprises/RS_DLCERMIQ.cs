using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 合格证邮寄信息推送响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCERMIQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CertificateExpressResult> List { get; set; }
    }
    /// <summary>
    /// 合格证邮寄信息推送
    /// </summary>
    public class CertificateExpressResult
    {
        /// <summary>
        /// 序号 varchar (10)
        /// </summary>
        [XmlElement("dataNo")]
        public string DataNo { get; set; }
        /// <summary>
        /// 处理结果varchar(8) 成功-S  失败-E
        /// </summary>
        [XmlElement("flag")]
        public string Flag { get; set; }
        /// <summary>
        /// 错误消息varchar (2)
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
