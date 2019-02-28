using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.6.6定活互转结构性存款支取交易结果查询响应主体
    /// </summary>
    public class V1_STRUCTTODEMANDQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.6.6定活互转结构性存款支取交易结果查询响应主体
        /// </summary>
        public STRUCTTODEMANDQUERYTRNRS STRUCTTODEMANDQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.6.6定活互转结构性存款支取交易结果查询响应主体
    /// </summary>
    public class STRUCTTODEMANDQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.6.6定活互转结构性存款支取交易结果查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public STRUCTTODEMANDQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.6定活互转结构性存款支取交易结果查询响应内容
    /// </summary>
    public class STRUCTTODEMANDQUERYTRN_RSBODY : STRUCTTODEMANDTRN_RSBODY
    {
    }
}
