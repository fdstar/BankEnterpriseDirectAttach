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
    /// 3.12.7.1定活互转智能定期存款互联互通—签约请求主体
    /// </summary>
    public class V1_INTGNTTIMEINTCONSIGNTRNRQ : IRequest<V1_INTGNTTIMEINTCONSIGNTRNRS>
    {
        /// <summary>
        /// 3.12.7.1定活互转智能定期存款互联互通—签约请求主体
        /// </summary>
        public INTGNTTIMEINTCONSIGNTRNRQ INTGNTTIMEINTCONSIGNTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.1定活互转智能定期存款互联互通—签约请求主体
    /// </summary>
    public class INTGNTTIMEINTCONSIGNTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.1定活互转智能定期存款互联互通—签约请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public INTGNTTIMEINTCONSIGNTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.1定活互转智能定期存款互联互通—签约请求内容
    /// </summary>
    public class INTGNTTIMEINTCONSIGNTRN_RQBODY
    {
        /// <summary>
        /// 签约账号最长32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 单位名称 最长60位 非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCOUNTNAME { get; set; }
        /// <summary>
        /// 留存金额 最低为0 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal OPENAMOUNT { get; set; }
    }
}
