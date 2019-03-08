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
    /// 3.19.8跨境资金池国内主账户信息查询请求主体
    /// </summary>
    public class V1_CBCPMAINACCTQUERYTRNRQ : IRequest<V1_CBCPMAINACCTQUERYTRNRS>
    {
        /// <summary>
        /// 3.19.8跨境资金池国内主账户信息查询请求主体
        /// </summary>
        public CBCPMAINACCTQUERYTRNRQ CBCPMAINACCTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.8跨境资金池国内主账户信息查询请求主体
    /// </summary>
    public class CBCPMAINACCTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.8跨境资金池国内主账户信息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMAINACCTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.8跨境资金池国内主账户信息查询请求内容
    /// </summary>
    public class CBCPMAINACCTQUERYTRN_RQBODY
    {
        /// <summary>
        /// 币种	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string CURRENCY { get; set; }
    }
}
