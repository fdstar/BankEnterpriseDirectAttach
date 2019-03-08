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
    /// 3.12.8.2定活互转同业一本通及互联互通查询请求主体
    /// </summary>
    public class V1_TRADEAPASSTRNRQ : IRequest<V1_TRADEAPASSTRNRS>
    {
        /// <summary>
        /// 3.12.8.2定活互转同业一本通及互联互通查询请求主体
        /// </summary>
        public TRADEAPASSTRNRQ TRADEAPASSTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.8.2定活互转同业一本通及互联互通查询请求主体
    /// </summary>
    public class TRADEAPASSTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.8.2定活互转同业一本通及互联互通查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public PAGED_RQACCT RQBODY { get; set; }
    }
}
