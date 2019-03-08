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
    /// 3.17.7虚拟资金池主账户属性查询请求主体
    /// </summary>
    public class V1_MAINACCTPROPQUERYTRNRQ : IRequest<V1_MAINACCTPROPQUERYTRNRS>
    {
        /// <summary>
        /// 3.17.7虚拟资金池主账户属性查询请求主体
        /// </summary>
        public MAINACCTPROPQUERYTRNRQ MAINACCTPROPQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.7虚拟资金池主账户属性查询请求主体
    /// </summary>
    public class MAINACCTPROPQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.7虚拟资金池主账户属性查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MAINACCTPROPQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.7虚拟资金池主账户属性查询请求内容
    /// </summary>
    public class MAINACCTPROPQUERYTRN_RQBODY
    {
        /// <summary>
        /// 主账号，18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
    }
}
