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
    /// 3.12.5.3定活互转智能通知存款登记请求主体
    /// </summary>
    public class V1_ICREGTRNRQ : IRequest<V1_ICREGTRNRS>
    {
        /// <summary>
        /// 3.12.5.3定活互转智能通知存款登记请求主体
        /// </summary>
        public ICREGTRNRQ ICREGTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.5.3定活互转智能通知存款登记请求主体
    /// </summary>
    public class ICREGTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.5.3定活互转智能通知存款登记请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public ICREGTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.5.3定活互转智能通知存款登记请求内容
    /// </summary>
    public class ICREGTRN_RQBODY
    {
        /// <summary>
        /// 活期账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 留存金额，不能低100,000 decimal(15,2)即整数位最长13位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal RETAINAMT { get; set; }
    }
}
