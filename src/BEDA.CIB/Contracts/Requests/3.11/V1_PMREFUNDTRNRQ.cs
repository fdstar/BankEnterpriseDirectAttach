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
    /// 3.11.3贵金属交易保证金划回申请请求主体
    /// </summary>
    public class V1_PMREFUNDTRNRQ : IRequest<V1_PMREFUNDTRNRS>
    {
        /// <summary>
        /// 3.11.3贵金属交易保证金划回申请请求主体
        /// </summary>
        public PMREFUNDTRNRQ PMREFUNDTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.3贵金属交易保证金划回申请请求主体
    /// </summary>
    public class PMREFUNDTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.3贵金属交易保证金划回申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMREFUNDTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.11.3贵金属交易保证金划回申请请求内容
    /// </summary>
    public class PMREFUNDTRN_RQBODY
    {
        /// <summary>
        /// 账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 划回金额，decimal(15,2) 即整数位最长13位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRNAMT { get; set; }
    }
}
