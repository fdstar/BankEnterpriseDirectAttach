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
    /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询请求主体
    /// </summary>
    public class V1_INTGNTTIMEINTCONQUERYTRNRQ : IRequest<V1_INTGNTTIMEINTCONQUERYTRNRS>
    {
        /// <summary>
        /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询请求主体
        /// </summary>
        public INTGNTTIMEINTCONQUERYTRNRQ INTGNTTIMEINTCONQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询请求主体
    /// </summary>
    public class INTGNTTIMEINTCONQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public INTGNTTIMEINTCONQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.2定活互转智能定期存款互联互通—签约账户查询请求内容
    /// </summary>
    public class INTGNTTIMEINTCONQUERYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 签约账号最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCOUNTNO { get; set; }
    }
}
