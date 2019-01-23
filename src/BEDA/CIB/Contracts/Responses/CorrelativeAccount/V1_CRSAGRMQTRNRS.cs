using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.10.2跨行账户他行账户协议查询响应主体
    /// </summary>
    public class V1_CRSAGRMQTRNRS : IResponse
    {
        /// <summary>
        /// 3.10.2跨行账户他行账户协议查询响应主体
        /// </summary>
        public CRSAGRMQTRNRS CRSAGRMQTRNRS { get; set; }
    }
    /// <summary>
    /// 3.10.2跨行账户他行账户协议查询响应主体
    /// </summary>
    public class CRSAGRMQTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.10.2跨行账户他行账户协议查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CRSAGRMQTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.10.2跨行账户他行账户协议查询响应内容
    /// </summary>
    public class CRSAGRMQTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.10.2跨行账户他行账户协议查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<CRSAGRMQTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.10.2跨行账户他行账户协议查询响应明细
    /// </summary>
    public class CRSAGRMQTRN_CONTENT
    {
        /// <summary>
        /// 我行账户，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 我行账户名，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 他行账户代号信息
        /// </summary>
        [XmlElement(Order = 2)]
        public CORRELATEACCT INTERACCT { get; set; }
        /// <summary>
        /// 协议号，最长140位
        /// </summary>
        [XmlElement(Order = 3)]
        public string AGRM { get; set; }
        /// <summary>
        /// 协议类型，1付款2查询
        /// </summary>
        [XmlElement(Order = 4)]
        public int AGRMTYPE { get; set; }
    }
}
