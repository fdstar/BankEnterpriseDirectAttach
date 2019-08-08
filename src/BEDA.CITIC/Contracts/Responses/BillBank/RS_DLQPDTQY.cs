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
    /// 代保管取票明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLQPDTQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillTookInfo> List { get; set; }
    }
    /// <summary>
    /// 代保管取票明细
    /// </summary>
    public class AgentBillTookInfo : AgentBillOperatedInfo
    {
        /// <summary>
        /// 取票人姓名varchar(60)
        /// </summary>
        [XmlElement("takerName")]
        public string TakerName { get; set; }
        /// <summary>
        /// 取票人证件号varchar(30)
        /// </summary>
        [XmlElement("takerID")]
        public string TakerID { get; set; }
        /// <summary>
        /// 取票人证件类型，char(1)，值域见附录4.6
        /// </summary>
        [XmlElement("takerIDType")]
        public string TakerIDType { get; set; }
        /// <summary>
        /// 申请状态char(1)，值域见附录4.2
        /// </summary>
        [XmlElement("appStt")]
        public string AppStt { get; set; }
        /// <summary>
        /// 申请编号varchar(18)
        /// </summary>
        [XmlElement("appNo")]
        public string AppNo { get; set; }
        /// <summary>
        /// 客户申请备注varchar(256)
        /// </summary>
        [XmlElement("cstAppMemo")]
        public string CstAppMemo { get; set; }
        /// <summary>
        /// 银行审核备注varchar(256)
        /// </summary>
        [XmlElement("bankAuditMemo")]
        public string BankAuditMemo { get; set; }
    }
}
