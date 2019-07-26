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
    /// 可追索人查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBRCQZS : RsBase
    {
        /// <summary>
        /// 总记录数 char(4)
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<RecoursablePerson> List { get; set; }
    }
    /// <summary>
    /// 可追索人
    /// </summary>
    public class RecoursablePerson
    {
        /// <summary>
        /// 可追索人名称 varchar(122)
        /// </summary>
        [XmlElement("RCVGNME")]
        public string RCVGNME { get; set; }
        /// <summary>
        /// 可追索人组织机构代码 varchar(20)
        /// </summary>
        [XmlElement("RECRCOD")]
        public string RECRCOD { get; set; }
        /// <summary>
        /// 可追索人账号 varchar(32)
        /// </summary>
        [XmlElement("RCVGACC")]
        public string RCVGACC { get; set; }
        /// <summary>
        /// 可追索人行号 varchar(20)
        /// </summary>
        [XmlElement("RCVGBNM")]
        public string RCVGBNM { get; set; }
    }
}