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
    /// 网银互联参与机构信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOBKQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<Branch> List { get; set; }
    }
    /// <summary>
    /// 网银互联参与机构信息
    /// </summary>
    public class Branch
    {
        /// <summary>
        /// 机构名称varchar(122)
        /// </summary>
        [XmlElement("branchName")]
        public string BranchName { get; set; }
        /// <summary>
        /// 机构号varchar(20)
        /// </summary>
        [XmlElement("branchNo")]
        public string BranchNo { get; set; }
    }
}
