using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.3跨境资金池利息查询响应主体
    /// </summary>
    public class V1_CBCPINTRSTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.3跨境资金池利息查询响应主体
        /// </summary>
        public CBCPINTRSTQUERYTRNRS CBCPINTRSTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.3跨境资金池利息查询响应主体
    /// </summary>
    public class CBCPINTRSTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.3跨境资金池利息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPINTRSTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.3跨境资金池利息查询响应内容
    /// </summary>
    public class CBCPINTRSTQUERYTRN_RSBODY
    {
        /// <summary>
        /// 成员活期账户代号 18位	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员活期账户名称，60位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 上存积数，Decimal(17,2)	非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? TOTALUPSCORE { get; set; }
        /// <summary>
        /// 上存利率，Decimal(9,7)	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? UPRATIO { get; set; }
        /// <summary>
        /// 上存利息，Decimal(17,2)	非必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal? UPINTE { get; set; }
        /// <summary>
        /// 透支积数，Decimal(17,2)	非必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? TOTALDOWNSCORE { get; set; }
        /// <summary>
        /// 透支利率，Decimal(9,7)	非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? DOWNRATIO { get; set; }
        /// <summary>
        /// 透支利息，Decimal(17,2)	非必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? DOWNINTE { get; set; }
    }
}
