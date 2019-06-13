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
    /// 支付联行信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBNKCOD : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<Tg> List { get; set; }
    }
    /// <summary>
    /// 支付联行信息
    /// </summary>
    public class Tg
    {
        /// <summary>
        /// 支付联行名称 varchar(122)
        /// </summary>
        [XmlElement("tgname")]
        public string Tgname { get; set; }
        /// <summary>
        /// 支付联行号 varchar(20)
        /// </summary>
        [XmlElement("tgfi")]
        public string Tgfi { get; set; }
    }
}
