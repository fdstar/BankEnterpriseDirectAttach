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
    /// 3.12.5.1定活互转智能通知存款签约关系查询请求主体
    /// </summary>
    public class V1_ICCONTRTRNRQ : IRequest<V1_ICCONTRTRNRS>
    {
        /// <summary>
        /// 3.12.5.1定活互转智能通知存款签约关系查询请求主体
        /// </summary>
        public ICCONTRTRNRQ ICCONTRTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.5.1定活互转智能通知存款签约关系查询请求主体
    /// </summary>
    public class ICCONTRTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.5.1定活互转智能通知存款签约关系查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public RQACCT RQBODY { get; set; }
    }
}
