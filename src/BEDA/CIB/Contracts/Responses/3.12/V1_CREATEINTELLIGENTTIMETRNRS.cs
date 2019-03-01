using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.7.5定活互转智能定期存款—开户响应主体
    /// </summary>
    public class V1_CREATEINTELLIGENTTIMETRNRS : IResponse
    {
        /// <summary>
        /// 3.12.7.5定活互转智能定期存款—开户响应主体
        /// </summary>
        public CREATEINTELLIGENTTIMETRNRS CREATEINTELLIGENTTIMETRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.7.5定活互转智能定期存款—开户响应主体
    /// </summary>
    public class CREATEINTELLIGENTTIMETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.7.5定活互转智能定期存款—开户响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CREATEINTELLIGENTTIMETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.5定活互转智能定期存款—开户响应内容
    /// </summary>
    public class CREATEINTELLIGENTTIMETRN_RSBODY
    {
        /// <summary>
        /// 签约账号(定期账号)	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 签约账号名称(定期)	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string FIXEDACCOUNTNAME { get; set; }
        /// <summary>
        /// 开户机构	非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string BANKNAME { get; set; }
        /// <summary>
        /// 账户余额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal ACCOUNTBALANCE { get; set; }
        /// <summary>
        /// 可用余额	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AVAILABLEBALANCE { get; set; }
        /// <summary>
        /// 存期 默认：按协议 必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string TERMTYPE { get; set; }
        /// <summary>
        /// 续存方式  不续存(默认) 必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string CONTINUETERM { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 40)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
