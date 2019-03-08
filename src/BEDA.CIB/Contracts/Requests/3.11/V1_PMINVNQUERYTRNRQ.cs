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
    /// 3.11.1.2贵金属库存查询请求主体
    /// </summary>
    public class V1_PMINVNQUERYTRNRQ : IRequest<V1_PMINVNQUERYTRNRS>
    {
        /// <summary>
        /// 3.11.1.2贵金属库存查询请求主体
        /// </summary>
        public PMINVNQUERYTRNRQ PMINVNQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.1.2贵金属库存查询请求主体
    /// </summary>
    public class PMINVNQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.1.2贵金属库存查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PAGED_RQACCT RQBODY { get; set; }
    }
}
