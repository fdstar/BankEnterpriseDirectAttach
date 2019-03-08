using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.12.5.2定活互转智能通知存款协议查询请求主体
    /// </summary>
    public class V1_ICAGMTTRNRQ : IRequest<V1_ICAGMTTRNRS>
    {
        /// <summary>
        /// 3.12.5.2定活互转智能通知存款协议查询请求主体
        /// </summary>
        public ICAGMTTRNRQ ICAGMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.5.2定活互转智能通知存款协议查询请求主体
    /// </summary>
    public class ICAGMTTRNRQ : BIZRQBASE
    {
    }
}
