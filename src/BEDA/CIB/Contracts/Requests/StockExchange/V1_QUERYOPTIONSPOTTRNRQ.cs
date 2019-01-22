using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.5.11期权现货资金查询请求主体
    /// </summary>
    public class V1_QUERYOPTIONSPOTTRNRQ : IRequest<V1_QUERYOPTIONSPOTTRNRS>
    {
        /// <summary>
        /// 3.5.11期权现货资金查询请求主体
        /// </summary>
        public QUERYOPTIONSPOTTRNRQ QUERYOPTIONSPOTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.11期权现货资金查询请求主体
    /// </summary>
    public class QUERYOPTIONSPOTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.11期权现货资金查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public QUERYOPTIONSPOTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.11期权现货资金查询请求内容
    /// </summary>
    public class QUERYOPTIONSPOTTRN_RQBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 资金账户，	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string FUNDACCTNO { get; set; }
    }
}
