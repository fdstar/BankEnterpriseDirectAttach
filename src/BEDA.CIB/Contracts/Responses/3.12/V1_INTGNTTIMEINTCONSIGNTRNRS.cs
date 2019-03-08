using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.7.1定活互转智能定期存款互联互通—签约响应主体
    /// </summary>
    public class V1_INTGNTTIMEINTCONSIGNTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.7.1定活互转智能定期存款互联互通—签约响应主体
        /// </summary>
        public INTGNTTIMEINTCONSIGNTRNRS INTGNTTIMEINTCONSIGNTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.7.1定活互转智能定期存款互联互通—签约响应主体
    /// </summary>
    public class INTGNTTIMEINTCONSIGNTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.7.1定活互转智能定期存款互联互通—签约响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public INTGNTTIMEINTCONSIGNTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.1定活互转智能定期存款互联互通—签约响应内容
    /// </summary>
    public class INTGNTTIMEINTCONSIGNTRN_RSBODY : Requests.INTGNTTIMEINTCONSIGNTRN_RQBODY
    {
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
