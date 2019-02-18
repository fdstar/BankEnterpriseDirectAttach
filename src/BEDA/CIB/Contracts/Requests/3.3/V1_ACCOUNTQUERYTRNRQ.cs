using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.3.5账户信息查询请求主体
    /// </summary>
    public class V1_ACCOUNTQUERYTRNRQ : IRequest<V1_ACCOUNTQUERYTRNRS>
    {
        /// <summary>
        /// 3.3.5账户信息查询
        /// </summary>
        public ACCOUNTQUERYTRNRQ ACCOUNTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.3.5账户信息查询
    /// </summary>
    public class ACCOUNTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 查询账户
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT RQBODY { get; set; }
    }
}
