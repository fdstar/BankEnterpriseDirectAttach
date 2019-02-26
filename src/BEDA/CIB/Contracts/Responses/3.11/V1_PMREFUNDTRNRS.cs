using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.11.3贵金属交易保证金划回申请响应主体
    /// </summary>
    public class V1_PMREFUNDTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.3贵金属交易保证金划回申请响应主体
        /// </summary>
        public PMREFUNDTRNRS PMREFUNDTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.3贵金属交易保证金划回申请响应主体
    /// </summary>
    public class PMREFUNDTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.3贵金属交易保证金划回申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMREFUNDTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.3贵金属交易保证金划回申请响应内容
    /// </summary>
    public class PMREFUNDTRN_RSBODY : BANKACCT
    {
        /// <summary>
        /// 划回金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 10)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
