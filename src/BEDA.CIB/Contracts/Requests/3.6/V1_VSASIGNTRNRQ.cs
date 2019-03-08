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
    /// 3.6.1虚拟主账户签约解约请求主体
    /// </summary>
    public class V1_VSASIGNTRNRQ : IRequest<V1_VSASIGNTRNRS>
    {
        /// <summary>
        /// 3.6.1虚拟主账户签约解约请求主体
        /// </summary>
        public VSASIGNTRNRQ VSASIGNTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.1虚拟主账户签约解约请求主体
    /// </summary>
    public class VSASIGNTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.6.1虚拟主账户签约解约请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public VSASIGNTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.6.1虚拟主账户签约解约请求内容
    /// </summary>
    public class VSASIGNTRN_RQBODY
    {
        /// <summary>
        /// 18位主账户	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// Y-签约 N-解约	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string SIGNFLG { get; set; }
    }
}
