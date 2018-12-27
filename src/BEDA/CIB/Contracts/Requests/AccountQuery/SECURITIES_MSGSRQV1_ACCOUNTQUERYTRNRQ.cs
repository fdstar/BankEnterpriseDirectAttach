using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 账户信息查询请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_ACCOUNTQUERYTRNRQ : IRequest<SECURITIES_MSGSRSV1_ACCOUNTQUERYTRNRS>
    {
        /// <summary>
        /// 账户信息查询
        /// </summary>
        public ACCOUNTQUERYTRNRQ ACCOUNTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 账户信息查询
    /// </summary>
    public class ACCOUNTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 查询账户
        /// </summary>
        [XmlElement(Order = 1)]
        public RQBODY RQBODY { get; set; }
    }
}
