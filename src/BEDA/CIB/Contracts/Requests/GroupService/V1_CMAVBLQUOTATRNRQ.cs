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
    /// 集团服务账户可用额度查询请求主体
    /// </summary>
    public class V1_CMAVBLQUOTATRNRQ : IRequest<V1_CMAVBLQUOTATRNRS>
    {
        /// <summary>
        /// 集团服务账户可用额度查询请求主体
        /// </summary>
        public CMAVBLQUOTATRNRQ CMAVBLQUOTATRNRQ { get; set; }
    }
    /// <summary>
    /// 集团服务账户可用额度查询请求主体
    /// </summary>
    public class CMAVBLQUOTATRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 集团服务账户可用额度查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CMAVBLQUOTATRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 集团服务账户可用额度查询请求内容
    /// </summary>
    public class CMAVBLQUOTATRN_RQBODY
    {
        /// <summary>
        /// 结算中心账户信息	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public RQACCT FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
    }
}
