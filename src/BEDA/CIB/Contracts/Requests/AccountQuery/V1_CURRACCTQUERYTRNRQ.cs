using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 活期账户信息查询请求主体
    /// </summary>
    public class V1_CURRACCTQUERYTRNRQ : IRequest<V1_CURRACCTQUERYTRNRS>
    {
        /// <summary>
        /// 活期账户信息查询
        /// </summary>
        public CURRACCTQUERYTRNRQ CURRACCTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 活期账户信息查询
    /// </summary>
    public class CURRACCTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 查询账户
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT RQBODY { get; set; }
    }
    /// <summary>
    /// 查询账户
    /// </summary>
    public class RQACCT
    {
        /// <summary>
        /// 查询账户代号，最长32位，必输
        /// </summary>
        public string ACCTID { get; set; }
    }
}
