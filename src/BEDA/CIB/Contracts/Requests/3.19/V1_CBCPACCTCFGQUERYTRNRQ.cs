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
    /// 3.19.11跨境资金池账户资金池属性查询请求主体
    /// </summary>
    public class V1_CBCPACCTCFGQUERYTRNRQ : IRequest<V1_CBCPACCTCFGQUERYTRNRS>
    {
        /// <summary>
        /// 3.19.11跨境资金池账户资金池属性查询请求主体
        /// </summary>
        public CBCPACCTCFGQUERYTRNRQ CBCPACCTCFGQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.11跨境资金池账户资金池属性查询请求主体
    /// </summary>
    public class CBCPACCTCFGQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.11跨境资金池账户资金池属性查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPACCTCFGQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.11跨境资金池账户资金池属性查询请求内容
    /// </summary>
    public class CBCPACCTCFGQUERYTRN_RQBODY
    {
        /// <summary>
        /// 成员活期账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNO { get; set; }
    }
}
