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
    /// 3.11.1.1贵金属账户签约查询请求主体
    /// </summary>
    public class V1_PMCONTRQUERYTRNRQ : IRequest<V1_PMCONTRQUERYTRNRS>
    {
        /// <summary>
        /// 3.11.1.1贵金属账户签约查询请求主体
        /// </summary>
        public PMCONTRQUERYTRNRQ PMCONTRQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.1.1贵金属账户签约查询请求主体
    /// </summary>
    public class PMCONTRQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.1.1贵金属账户签约查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public RQACCT RQBODY { get; set; }
    }
}
