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
    /// 现金管理代理收款信息查询（推送账单）响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMPROXYQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentReceiptResult> List { get; set; }
    }
    /// <summary>
    /// 现金管理代理收款信息查询（推送账单）
    /// </summary>
    public class AgentReceiptResult : Requests.AgentReceipt
    {
        /// <summary>
        /// 交易状态 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
