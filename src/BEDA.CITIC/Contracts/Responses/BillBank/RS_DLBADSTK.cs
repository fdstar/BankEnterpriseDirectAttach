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
    /// 票据库交易状态同步响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBADSTK : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillStatus> List { get; set; }
    }
    /// <summary>
    /// 票据库交易状态
    /// </summary>
    public class AgentBillStatus
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
        /// <summary>
        /// 制单状态varchar(2)，值域见附录4.1
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
        /// <summary>
        /// 申请编号varchar(18)
        /// </summary>
        [XmlElement("appNo")]
        public string AppNo { get; set; }
        /// <summary>
        /// 申请结果状态char(1)，值域见附录4.2
        /// </summary>
        [XmlElement("appResStt")]
        public string AppResStt { get; set; }
        /// <summary>
        /// 查询号varchar(20)
        /// </summary>
        [XmlElement("qryNo")]
        public string QryNo { get; set; }
        /// <summary>
        /// 客户备注varchar(256)
        /// </summary>
        [XmlElement("cstMemo")]
        public string CstMemo { get; set; }
        /// <summary>
        /// 银行备注varchar(256)
        /// </summary>
        [XmlElement("bankMemo")]
        public string BankMemo { get; set; }
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
