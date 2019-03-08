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
    /// 3.12.6.3定活互转结构性存款开户交易结果查询请求主体
    /// </summary>
    public class V1_DEMANDTOSTRUCTQUERYTRNRQ : IRequest<V1_DEMANDTOSTRUCTQUERYTRNRS>
    {
        /// <summary>
        /// 3.12.6.3定活互转结构性存款开户交易结果查询请求主体
        /// </summary>
        public DEMANDTOSTRUCTQUERYTRNRQ DEMANDTOSTRUCTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.6.3定活互转结构性存款开户交易结果查询请求主体
    /// </summary>
    public class DEMANDTOSTRUCTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.6.3定活互转结构性存款开户交易结果查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public DEMANDTOSTRUCTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.3定活互转结构性存款开户交易结果查询请求内容
    /// </summary>
    public class DEMANDTOSTRUCTQUERYTRN_RQBODY
    {
        /// <summary>
        /// 结构性存款开户请求流水号TRNUID值	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTREFNO { get; set; }
    }
}
