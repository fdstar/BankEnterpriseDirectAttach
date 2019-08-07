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
    /// 代保管票据质押明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLZYDTQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillPawnedInfo> List { get; set; }
    }
    /// <summary>
    /// 代保管票据质押明细
    /// </summary>
    public class AgentBillPawnedInfo: AgentBillInfo
    {
        /// <summary>
        /// 质权人机构号varchar(20)
        /// </summary>
        [XmlElement("pawnBranchNo")]
        public string PawnBranchNo { get; set; }
        /// <summary>
        /// 质权人机构名称varchar(122)
        /// </summary>
        [XmlElement("pawnBranchNm")]
        public string PawnBranchNm { get; set; }
    }
}
