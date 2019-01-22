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
    /// 3.5.2证券资金清算汇划查询请求主体
    /// </summary>
    public class V1_STOCKQUERYTRNRQ : IRequest<V1_STOCKQUERYTRNRS>
    {
        /// <summary>
        /// 3.5.2证券资金清算汇划查询请求主体
        /// </summary>
        public STOCKQUERYTRNRQ STOCKQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.2证券资金清算汇划查询请求主体
    /// </summary>
    public class STOCKQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.2证券资金清算汇划查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public STOCKQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.2证券资金清算汇划查询请求内容
    /// </summary>
    public class STOCKQUERYTRN_RQBODY : PAGED_RQACCT
    {
        /// <summary>
        /// 客户端交易流水号，最长30位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLIENTREF { get; set; }
    }
}
