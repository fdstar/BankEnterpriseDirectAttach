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
    /// 3.19.3跨境资金池利息查询请求主体
    /// </summary>
    public class V1_CBCPINTRSTQUERYTRNRQ : IRequest<V1_CBCPINTRSTQUERYTRNRS>
    {
        /// <summary>
        /// 3.19.3跨境资金池利息查询请求主体
        /// </summary>
        public CBCPINTRSTQUERYTRNRQ CBCPINTRSTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.3跨境资金池利息查询请求主体
    /// </summary>
    public class CBCPINTRSTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.3跨境资金池利息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPINTRSTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.3跨境资金池利息查询请求内容
    /// </summary>
    public class CBCPINTRSTQUERYTRN_RQBODY
    {
        /// <summary>
        /// 成员活期账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNO { get; set; }
    }
}
