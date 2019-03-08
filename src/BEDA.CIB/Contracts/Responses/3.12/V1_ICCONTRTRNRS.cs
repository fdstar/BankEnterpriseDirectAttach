using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.5.1定活互转智能通知存款签约关系查询响应主体
    /// </summary>
    public class V1_ICCONTRTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.5.1定活互转智能通知存款签约关系查询响应主体
        /// </summary>
        public ICCONTRTRNRS ICCONTRTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.5.1定活互转智能通知存款签约关系查询响应主体
    /// </summary>
    public class ICCONTRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.5.1定活互转智能通知存款签约关系查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ICCONTRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.5.1定活互转智能通知存款签约关系查询响应内容
    /// </summary>
    public class ICCONTRTRN_RSBODY
    {
        /// <summary>
        /// 活期账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTAMT CURRACCTINFO { get; set; }
        /// <summary>
        /// 通知账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string CALLACCTID { get; set; }
        /// <summary>
        /// 通知账户余额，decimal(17,2) 即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 留存金额，decimal(17,2) 即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal RETAINAMT { get; set; }
        /// <summary>
        /// 周期, 默认D07（7天）D01 一天通知 D07 七天通知
        /// </summary>
        [XmlElement(Order = 4)]
        public string TERM { get; set; }
    }
}
