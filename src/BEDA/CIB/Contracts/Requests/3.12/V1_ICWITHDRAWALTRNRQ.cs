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
    /// 3.12.5.5定活互转智能通知存款资金支取请求主体
    /// </summary>
    public class V1_ICWITHDRAWALTRNRQ : IRequest<V1_ICWITHDRAWALTRNRS>
    {
        /// <summary>
        /// 3.12.5.5定活互转智能通知存款资金支取请求主体
        /// </summary>
        public ICWITHDRAWALTRNRQ ICWITHDRAWALTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.5.5定活互转智能通知存款资金支取请求主体
    /// </summary>
    public class ICWITHDRAWALTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.5.5定活互转智能通知存款资金支取请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public ICWITHDRAWALTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.5.5定活互转智能通知存款资金支取请求内容
    /// </summary>
    public class ICWITHDRAWALTRN_RQBODY
    {
        /// <summary>
        /// 通知存款账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 支取金额，decimal(15,2) 即整数位最长13位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TRNAMT { get; set; }
    }
}
