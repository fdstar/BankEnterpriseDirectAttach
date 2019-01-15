using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 定期存款信息查询请求主体
    /// </summary>
    public class V1_TIMEDEPOSITQUERYTRNRQ : IRequest<V1_TIMEDEPOSITQUERYTRNRS>
    {
        /// <summary>
        /// 定期存款信息查询
        /// </summary>
        public TIMEDEPOSITQUERYTRNRQ TIMEDEPOSITQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 定期存款信息查询
    /// </summary>
    public class TIMEDEPOSITQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 查询账户
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT RQBODY { get; set; }
    }
}
