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
    /// 备付金账户余额查询(他行)响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOTACDT : RsBase
    {
        /// <summary>
        /// 总记录数 int
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AccTransSummaryFromOther> List { get; set; }
    }
}
