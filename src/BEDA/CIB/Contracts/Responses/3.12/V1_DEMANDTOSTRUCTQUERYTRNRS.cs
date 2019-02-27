using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.6.3定活互转结构性存款开户交易结果查询响应主体
    /// </summary>
    public class V1_DEMANDTOSTRUCTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.6.3定活互转结构性存款开户交易结果查询响应主体
        /// </summary>
        public DEMANDTOSTRUCTQUERYTRNRS DEMANDTOSTRUCTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.6.3定活互转结构性存款开户交易结果查询响应主体
    /// </summary>
    public class DEMANDTOSTRUCTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.6.3定活互转结构性存款开户交易结果查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DEMANDTOSTRUCTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.3定活互转结构性存款开户交易结果查询响应内容
    /// </summary>
    public class DEMANDTOSTRUCTQUERYTRN_RSBODY : DEMANDTOSTRUCTTRN_RSBODY
    {
    }
}
