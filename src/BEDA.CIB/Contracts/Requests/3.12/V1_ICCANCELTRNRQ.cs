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
    /// 3.12.5.4定活互转智能通知存款撤销请求主体
    /// </summary>
    public class V1_ICCANCELTRNRQ : IRequest<V1_ICCANCELTRNRS>
    {
        /// <summary>
        /// 3.12.5.4定活互转智能通知存款撤销请求主体
        /// </summary>
        public ICCANCELTRNRQ ICCANCELTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.5.4定活互转智能通知存款撤销请求主体
    /// </summary>
    public class ICCANCELTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.5.4定活互转智能通知存款撤销请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT RQBODY { get; set; }
    }
}
