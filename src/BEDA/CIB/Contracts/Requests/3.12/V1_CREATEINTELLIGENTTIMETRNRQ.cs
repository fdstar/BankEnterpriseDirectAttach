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
    /// 3.12.7.5定活互转智能定期存款—开户请求主体
    /// </summary>
    public class V1_CREATEINTELLIGENTTIMETRNRQ : IRequest<V1_CREATEINTELLIGENTTIMETRNRS>
    {
        /// <summary>
        /// 3.12.7.5定活互转智能定期存款—开户请求主体
        /// </summary>
        public CREATEINTELLIGENTTIMETRNRQ CREATEINTELLIGENTTIMETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.5定活互转智能定期存款—开户请求主体
    /// </summary>
    public class CREATEINTELLIGENTTIMETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.5定活互转智能定期存款—开户请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CREATEINTELLIGENTTIMETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.5定活互转智能定期存款—开户请求内容
    /// </summary>
    public class CREATEINTELLIGENTTIMETRN_RQBODY
    {
        /// <summary>
        /// 签约账号最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 账户名称	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCOUNTNAME { get; set; }
        /// <summary>
        /// 留存金额 最低为0 必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal OPENAMOUNT { get; set; }
    }
}
