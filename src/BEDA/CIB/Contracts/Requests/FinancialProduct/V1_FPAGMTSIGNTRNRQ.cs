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
    /// 3.8.7理财产品签约-解约请求主体
    /// </summary>
    public class V1_FPAGMTSIGNTRNRQ : IRequest<V1_FPAGMTSIGNTRNRS>
    {
        /// <summary>
        /// 3.8.7理财产品签约-解约请求主体
        /// </summary>
        public FPAGMTSIGNTRNRQ FPAGMTSIGNTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.7理财产品签约-解约请求主体
    /// </summary>
    public class FPAGMTSIGNTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.7理财产品签约-解约请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FPAGMTSIGNTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.8.7理财产品签约-解约请求内容
    /// </summary>
    public class FPAGMTSIGNTRN_RQBODY
    {
        /// <summary>
        /// 账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 产品代码，8位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string PRODNO { get; set; }
        /// <summary>
        /// Y-签约 N-解约	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string SIGNFLG { get; set; }
        /// <summary>
        /// 协议书编号，最长17位	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string AGRM { get; set; }
    }
}
