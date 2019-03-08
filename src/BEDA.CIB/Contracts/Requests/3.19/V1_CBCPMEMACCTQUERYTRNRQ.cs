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
    /// 3.19.7跨境资金池成员账号信息查询请求主体
    /// </summary>
    public class V1_CBCPMEMACCTQUERYTRNRQ : IRequest<V1_CBCPMEMACCTQUERYTRNRS>
    {
        /// <summary>
        /// 3.19.7跨境资金池成员账号信息查询请求主体
        /// </summary>
        public CBCPMEMACCTQUERYTRNRQ CBCPMEMACCTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.7跨境资金池成员账号信息查询请求主体
    /// </summary>
    public class CBCPMEMACCTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.7跨境资金池成员账号信息查询请求
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMEMACCTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.7跨境资金池成员账号信息查询请求内容
    /// </summary>
    public class CBCPMEMACCTQUERYTRN_RQBODY
    {
        /// <summary>
        /// 成员活期账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNO { get; set; }
    }
}
