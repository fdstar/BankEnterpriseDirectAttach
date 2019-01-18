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
    /// 集团业务内部往来查询请求主体
    /// </summary>
    public class V1_CMINNERQUERYTRNRQ : IRequest<V1_CMINNERQUERYTRNRS>
    {
        /// <summary>
        /// 集团业务内部往来查询请求主体
        /// </summary>
        public CMINNERQUERYTRNRQ CMINNERQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 集团业务内部往来查询请求主体
    /// </summary>
    public class CMINNERQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 内部往来查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CMINNERQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 集团业务内部往来查询请求内容
    /// </summary>
    public class CMINNERQUERYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 结算中心账户信息，必输
        /// </summary>
        [XmlElement(Order = 0)]
        public RQACCT FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户信息，必输
        /// 查询结算中心明细时，此处输入结算中心帐号
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT MBRACCT { get; set; }
    }
}
