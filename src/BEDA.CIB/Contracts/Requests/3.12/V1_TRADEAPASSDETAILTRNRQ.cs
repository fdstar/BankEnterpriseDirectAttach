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
    /// 3.12.8.1定活互转一本帐及互联互通请求主体
    /// </summary>
    public class V1_TRADEAPASSDETAILTRNRQ : IRequest<V1_TRADEAPASSDETAILTRNRS>
    {
        /// <summary>
        /// 3.12.8.1定活互转一本帐及互联互通请求主体
        /// </summary>
        public TRADEAPASSDETAILTRNRQ TRADEAPASSDETAILTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.8.1定活互转一本帐及互联互通请求主体
    /// </summary>
    public class TRADEAPASSDETAILTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.8.1定活互转一本帐及互联互通请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public PAGED_RQACCT RQBODY { get; set; }
    }
}
