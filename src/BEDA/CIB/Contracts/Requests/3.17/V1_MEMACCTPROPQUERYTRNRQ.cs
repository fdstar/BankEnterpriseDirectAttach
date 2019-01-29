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
    /// 3.17.8虚拟资金池成员账户属性查询请求主体
    /// </summary>
    public class V1_MEMACCTPROPQUERYTRNRQ : IRequest<V1_MEMACCTPROPQUERYTRNRS>
    {
        /// <summary>
        /// 3.17.8虚拟资金池成员账户属性查询请求主体
        /// </summary>
        public MEMACCTPROPQUERYTRNRQ MEMACCTPROPQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.8虚拟资金池成员账户属性查询请求主体
    /// </summary>
    public class MEMACCTPROPQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.8虚拟资金池成员账户属性查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MEMACCTPROPQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.8虚拟资金池成员账户属性查询请求内容
    /// </summary>
    public class MEMACCTPROPQUERYTRN_RQBODY
    {
        /// <summary>
        /// 成员账号，18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
    }
}
