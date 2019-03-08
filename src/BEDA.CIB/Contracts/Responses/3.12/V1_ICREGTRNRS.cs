using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.5.3定活互转智能通知存款登记响应主体
    /// </summary>
    public class V1_ICREGTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.5.3定活互转智能通知存款登记响应主体
        /// </summary>
        public ICREGTRNRS ICREGTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.5.3定活互转智能通知存款登记响应主体
    /// </summary>
    public class ICREGTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.5.3定活互转智能通知存款登记响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ICREGTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.5.3定活互转智能通知存款登记响应内容
    /// </summary>
    public class ICREGTRN_RSBODY
    {
        /// <summary>
        /// 活期账户信息	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTAMT CURRACCTINFO { get; set; }
        /// <summary>
        /// 通知账户信息	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public ACCTAMT CALLACCTINFO { get; set; }
        /// <summary>
        /// 留存金额，decimal(15,2)  即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal RETAINAMT { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 30)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
