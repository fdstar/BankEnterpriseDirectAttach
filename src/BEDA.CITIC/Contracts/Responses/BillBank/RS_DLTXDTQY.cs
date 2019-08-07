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
    /// 代保管票据贴现明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLTXDTQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgentBillDiscountedInfo> List { get; set; }
    }
    /// <summary>
    /// 代保管票据贴现明细
    /// </summary>
    public class AgentBillDiscountedInfo: AgentBillInfo
    {
        /// <summary>
        /// 贴入行机构号varchar(20)
        /// </summary>
        [XmlElement("discBranchNo")]
        public string DiscBranchNo { get; set; }
        /// <summary>
        /// 贴入行机构名称varchar(122)
        /// </summary>
        [XmlElement("discBranchNm")]
        public string DiscBranchNm { get; set; }
        /// <summary>
        /// 转让标识char(4)，EM00：可再转让，EM01：不可再转让
        /// </summary>
        [XmlElement("endorseMk")]
        public string EndorseMk { get; set; }
    }
}
