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
    /// 代保管存票查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillDepositedInfo> List { get; set; }
    }
    /// <summary>
    /// 代保管存票
    /// </summary>
    public class AgentBillDepositedInfo : AgentBillOperatedInfo
    {
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
    }
}
