using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.1.8电子商业汇票可追索人查询响应主体
    /// </summary>
    public class V1_EBRECRQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.8电子商业汇票可追索人查询响应主体
        /// </summary>
        public EBRECRQUERYTRNRS EBRECRQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.8电子商业汇票可追索人查询响应主体
    /// </summary>
    public class EBRECRQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.8电子商业汇票可追索人查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBRECRQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.8电子商业汇票可追索人查询响应内容
    /// </summary>
    public class EBRECRQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.8电子商业汇票可追索人查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<RECOURSEACCT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.8电子商业汇票可追索人查询响应明细
    /// </summary>
    public class RECOURSEACCT
    {
        /// <summary>
        /// 账户代号,最大32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 名称,最大60位
        /// </summary>
        [XmlElement(Order = 2)]
        public string NAME { get; set; }
        /// <summary>
        /// 开户行号,最大12位
        /// </summary>
        [XmlElement(Order = 3)]
        public string BANKNUM { get; set; }
        /// <summary>
        /// 开户行名,最大60位
        /// </summary>
        [XmlElement(Order = 4)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 组织机构代码,最大10位
        /// </summary>
        [XmlElement(Order = 5)]
        public string ORGID { get; set; }
    }
}
