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
    /// 委托ECDS查询查复明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLWTECQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillECDSQueryInfo> List { get; set; }
    }
    /// <summary>
    /// 委托ECDS查询查复明细
    /// </summary>
    public class AgentBillECDSQueryInfo : AgentBillApplyInfo
    {
        /// <summary>
        /// 查询号varchar(20)
        /// </summary>
        [XmlElement("qryNo")]
        public string QryNo { get; set; }
    }
}
