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
    /// 代保管票据信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBADQDB : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillInfo> List { get; set; }
    }
    /// <summary>
    /// 代保管票据信息
    /// </summary>
    public class AgentBillInfo : BillOperatingInfo
    {
        /// <summary>
        /// 业务流水号varchar(18)
        /// </summary>
        [XmlElement("bsnFlwNo")]
        public string BsnFlwNo { get; set; }
    }
}
