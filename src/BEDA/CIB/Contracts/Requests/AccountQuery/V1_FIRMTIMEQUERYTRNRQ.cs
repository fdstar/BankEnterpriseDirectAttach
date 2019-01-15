using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 单位定期一本通账户查询请求主体
    /// </summary>
    public class V1_FIRMTIMEQUERYTRNRQ : IRequest<V1_FIRMTIMEQUERYTRNRS>
    {
        /// <summary>
        /// 单位定期一本通账户查询
        /// </summary>
        public FIRMTIMEQUERYTRNRQ FIRMTIMEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 单位定期一本通账户查询
    /// </summary>
    public class FIRMTIMEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 查询账户
        /// </summary>
        [XmlElement(Order = 1)]
        public PAGED_RQBODY RQBODY { get; set; }
    }
}
