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
    /// 3.11.1.3贵金属交易资金查询请求主体
    /// </summary>
    public class V1_PMFUNDQUERYTRNRQ : IRequest<V1_PMFUNDQUERYTRNRS>
    {
        /// <summary>
        /// 3.11.1.3贵金属交易资金查询请求主体
        /// </summary>
        public PMFUNDQUERYTRNRQ PMFUNDQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.1.3贵金属交易资金查询请求主体
    /// </summary>
    public class PMFUNDQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.1.3贵金属交易资金查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public RQACCT RQBODY { get; set; }
    }
}
