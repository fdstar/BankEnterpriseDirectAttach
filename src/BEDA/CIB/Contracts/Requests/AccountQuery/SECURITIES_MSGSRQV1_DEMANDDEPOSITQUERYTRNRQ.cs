using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 非定期存款信息查询请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_DEMANDDEPOSITQUERYTRNRQ : IRequest<SECURITIES_MSGSRSV1_DEMANDDEPOSITQUERYTRNRS>
    {
        /// <summary>
        /// 非定期存款信息查询
        /// </summary>
        public DEMANDDEPOSITQUERYTRNRQ DEMANDDEPOSITQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 非定期存款信息查询
    /// </summary>
    public class DEMANDDEPOSITQUERYTRNRQ
    {
        /// <summary>
        /// 客户端交易的唯一流水号，最长30位，必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string TRNUID { get; set; }
        /// <summary>
        /// 查询账户
        /// </summary>
        [XmlElement(Order = 1)]
        public RQBODY RQBODY { get; set; }
    }
}
