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
    /// 台账账号信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLAGEACC : RsBase
    {
        /// <summary>
        /// 总笔数 int
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentAccount> List { get; set; }
    }
    /// <summary>
    /// 台账账号
    /// </summary>
    public class AgentAccount
    {
        /// <summary>
        /// 证券公司代码 char(8)
        /// </summary>
        [XmlElement("agentCode")]
        public string AgentCode { get; set; }
        /// <summary>
        /// 证券公司名称 varchar(62)
        /// </summary>
        [XmlElement("agentNm")]
        public string AgentNm { get; set; }
        /// <summary>
        /// 台账账号 varchar(30)
        /// </summary>
        [XmlElement("agentAccNo")]
        public string AgentAccNo { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
    }
}
