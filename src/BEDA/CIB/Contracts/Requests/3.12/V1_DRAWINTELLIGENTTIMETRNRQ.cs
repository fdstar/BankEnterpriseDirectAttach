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
    /// 3.12.7.8定活互转智能定期存款—资金支取请求主体
    /// </summary>
    public class V1_DRAWINTELLIGENTTIMETRNRQ : IRequest<V1_DRAWINTELLIGENTTIMETRNRS>
    {
        /// <summary>
        /// 3.12.7.8定活互转智能定期存款—资金支取请求主体
        /// </summary>
        public DRAWINTELLIGENTTIMETRNRQ DRAWINTELLIGENTTIMETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.8定活互转智能定期存款—资金支取请求主体
    /// </summary>
    public class DRAWINTELLIGENTTIMETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.8定活互转智能定期存款—资金支取请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public DRAWINTELLIGENTTIMETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.8定活互转智能定期存款—资金支取请求内容
    /// </summary>
    public class DRAWINTELLIGENTTIMETRN_RQBODY
    {
        /// <summary>
        /// 签约活期账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 签约定期账号	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 支取金额金额 最低为10000 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal AMOUNT { get; set; }
    }
}
