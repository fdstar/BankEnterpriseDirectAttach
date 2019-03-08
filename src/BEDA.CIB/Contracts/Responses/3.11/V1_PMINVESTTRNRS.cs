using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.11.2贵金属交易入金申请响应主体
    /// </summary>
    public class V1_PMINVESTTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.2贵金属交易入金申请响应主体
        /// </summary>
        public PMINVESTTRNRS PMINVESTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.2贵金属交易入金申请响应主体
    /// </summary>
    public class PMINVESTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.2贵金属交易入金申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMINVESTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.2贵金属交易入金申请响应内容
    /// </summary>
    public class PMINVESTTRN_RSBODY : BANKACCT
    {
        /// <summary>
        /// 入金金额，decimal(15,2)  即整数位最长13位，小数位2位
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
