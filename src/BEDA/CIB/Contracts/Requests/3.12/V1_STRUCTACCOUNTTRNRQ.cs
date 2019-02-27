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
    /// 3.12.6.4定活互转结构性存款账户信息查询请求主体
    /// </summary>
    public class V1_STRUCTACCOUNTTRNRQ : IRequest<V1_STRUCTACCOUNTTRNRS>
    {
        /// <summary>
        /// 3.12.6.4定活互转结构性存款账户信息查询请求主体
        /// </summary>
        public STRUCTACCOUNTTRNRQ STRUCTACCOUNTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.6.4定活互转结构性存款账户信息查询请求主体
    /// </summary>
    public class STRUCTACCOUNTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.6.4定活互转结构性存款账户信息查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public STRUCTACCOUNTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.4定活互转结构性存款账户信息查询请求内容
    /// </summary>
    public class STRUCTACCOUNTTRN_RQBODY
    {
        /// <summary>
        /// 上网登记的人民币活期账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCT { get; set; }
    }
}
