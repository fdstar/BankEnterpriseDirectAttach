using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 定期账户查询请求主体
    /// </summary>
    public class V1_TIMEQUERYTRNRQ : IRequest<V1_TIMEQUERYTRNRS>
    {
        /// <summary>
        /// 定期账户查询
        /// </summary>
        public TIMEQUERYTRNRQ TIMEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 定期账户查询
    /// </summary>
    public class TIMEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 查询账户
        /// </summary>
        [XmlElement(Order = 1)]
        public PAGED_RQACCT RQBODY { get; set; }
    }
    /// <summary>
    /// 分页查询账户
    /// </summary>
    public class PAGED_RQACCT : RQACCT
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
    }
}
