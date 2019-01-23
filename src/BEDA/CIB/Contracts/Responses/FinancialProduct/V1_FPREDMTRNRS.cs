using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.8.2理财产品赎回/撤销赎回功能响应主体
    /// </summary>
    public class V1_FPREDMTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.2理财产品赎回/撤销赎回功能响应主体
        /// </summary>
        public FPREDMTRNRS FPREDMTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.2理财产品赎回/撤销赎回功能响应主体
    /// </summary>
    public class FPREDMTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.2理财产品赎回/撤销赎回功能响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPREDMTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.2理财产品赎回/撤销赎回功能响应内容
    /// </summary>
    public class FPREDMTRN_RSBODY
    {
        /// <summary>
        /// 产品代码，8位
        /// </summary>
        [XmlElement(Order = 0)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 2)]
        public string NAME { get; set; }
        /// <summary>
        /// 赎回份额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal REDMAMT { get; set; }
        /// <summary>
        /// 可用余额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AVAILBAL { get; set; }
        /// <summary>
        /// 业务受理编号，最长16位
        /// </summary>
        [XmlElement(Order = 5)]
        public string ACCEPTNO { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 6)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
