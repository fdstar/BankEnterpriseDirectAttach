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
    /// 3.12.3活期转通知请求主体
    /// </summary>
    public class V1_CCCURR2CALLTRNRQ : IRequest<V1_CCCURR2CALLTRNRS>
    {
        /// <summary>
        /// 3.12.3活期转通知请求主体
        /// </summary>
        public CCCURR2CALLTRNRQ CCCURR2CALLTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.3活期转通知请求主体
    /// </summary>
    public class CCCURR2CALLTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.3活期转通知请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CCCURR2CALLTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.3活期转通知请求内容
    /// </summary>
    public class CCCURR2CALLTRN_RQBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 存期 D01 一天通知 D07 七天通知    必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string TERM { get; set; }
        /// <summary>
        /// 转出金额，decimal(15,2) 即整数位最长13位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TRNAMT { get; set; }
    }
}
