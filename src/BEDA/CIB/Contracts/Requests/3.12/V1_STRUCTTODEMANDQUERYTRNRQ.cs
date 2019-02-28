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
    /// 3.12.6.6定活互转结构性存款支取交易结果查询请求主体
    /// </summary>
    public class V1_STRUCTTODEMANDQUERYTRNRQ : IRequest<V1_STRUCTTODEMANDQUERYTRNRS>
    {
        /// <summary>
        /// 3.12.6.6定活互转结构性存款支取交易结果查询请求主体
        /// </summary>
        public STRUCTTODEMANDQUERYTRNRQ STRUCTTODEMANDQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.6.6定活互转结构性存款支取交易结果查询请求主体
    /// </summary>
    public class STRUCTTODEMANDQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.6.6定活互转结构性存款支取交易结果查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public STRUCTTODEMANDQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.6定活互转结构性存款支取交易结果查询请求内容
    /// </summary>
    public class STRUCTTODEMANDQUERYTRN_RQBODY
    {
        /// <summary>
        /// 结构性存款支取请求流水号TRNUID值	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTREFNO { get; set; }
    }
}
