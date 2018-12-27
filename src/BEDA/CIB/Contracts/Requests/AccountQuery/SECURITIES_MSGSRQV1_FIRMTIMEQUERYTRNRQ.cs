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
    public class SECURITIES_MSGSRQV1_FIRMTIMEQUERYTRNRQ : IRequest<SECURITIES_MSGSRSV1_FIRMTIMEQUERYTRNRS>
    {
        /// <summary>
        /// 单位定期一本通账户查询
        /// </summary>
        public FIRMTIMEQUERYTRNRQ FIRMTIMEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 单位定期一本通账户查询
    /// </summary>
    public class FIRMTIMEQUERYTRNRQ
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
        public PAGED_RQBODY RQBODY { get; set; }
    }
}
