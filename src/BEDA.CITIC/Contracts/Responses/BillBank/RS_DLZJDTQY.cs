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
    /// 代保管票据质押解除明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLZJDTQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillApplyInfo> List { get; set; }
    }
    /// <summary>
    /// 代保管票据申请信息
    /// </summary>
    public class AgentBillApplyInfo : AgentBillOperatedInfo
    {
        /// <summary>
        /// 票据ID int(20)
        /// </summary>
        [XmlElement("billID")]
        public string BillID { get; set; }
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
