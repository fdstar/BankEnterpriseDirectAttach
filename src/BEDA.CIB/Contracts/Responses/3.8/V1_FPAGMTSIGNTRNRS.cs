using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.8.7理财产品签约-解约响应主体
    /// </summary>
    public class V1_FPAGMTSIGNTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.7理财产品签约-解约响应主体
        /// </summary>
        public FPAGMTSIGNTRNRS FPAGMTSIGNTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.7理财产品签约-解约响应主体
    /// </summary>
    public class FPAGMTSIGNTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.7理财产品签约-解约响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPAGMTSIGNTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.7理财产品签约-解约响应内容
    /// </summary>
    public class FPAGMTSIGNTRN_RSBODY
    {
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 产品代码，8位
        /// </summary>
        [XmlElement(Order = 1)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 与协议对应的序列号（CIBLCCPxxx）,最长20位
        /// </summary>
        [XmlElement(Order = 2)]
        public string AGRM { get; set; }
        /// <summary>
        /// 操作结果SUCC成功- FAIL-失败
        /// </summary>
        [XmlElement(Order = 3)]
        public string RESULT { get; set; }
        /// <summary>
        /// 处理结果是否为成功，对应<see cref="RESULT"/>，SUCC时返回true
        /// </summary>
        [XmlIgnore]
        public bool IsSuccess
        {
            get { return "SUCC".Equals(this.RESULT, StringComparison.OrdinalIgnoreCase); }
        }
    }
}
