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
    /// 3.12.7.6定活互转智能定期存款账户查询请求主体
    /// </summary>
    public class V1_QUERYINTELLIGENTTIMETRNRQ : IRequest<V1_QUERYINTELLIGENTTIMETRNRS>
    {
        /// <summary>
        /// 3.12.7.6定活互转智能定期存款账户查询请求主体
        /// </summary>
        public QUERYINTELLIGENTTIMETRNRQ QUERYINTELLIGENTTIMETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.6定活互转智能定期存款账户查询请求主体
    /// </summary>
    public class QUERYINTELLIGENTTIMETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.6定活互转智能定期存款账户查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public QUERYINTELLIGENTTIMETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.6定活互转智能定期存款账户查询请求内容
    /// </summary>
    public class QUERYINTELLIGENTTIMETRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 签约活期账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCOUNTNO { get; set; }
    }
}
