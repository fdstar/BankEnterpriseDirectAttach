using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.2跨境资金池利息分配响应主体
    /// </summary>
    public class V1_CBCPINTERESTADJUSTTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.2跨境资金池利息分配响应主体
        /// </summary>
        public CBCPINTERESTADJUSTTRNRS CBCPINTERESTADJUSTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.2跨境资金池利息分配响应主体
    /// </summary>
    public class CBCPINTERESTADJUSTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.2跨境资金池利息分配响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPINTERESTADJUSTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.2跨境资金池利息分配响应内容
    /// </summary>
    public class CBCPINTERESTADJUSTTRN_RSBODY
    {
        /// <summary>
        /// 主账号，18位	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 主账户名称	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCTNAME { get; set; }
        /// <summary>
        /// 成员账号，18位	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string MEMACCTNO { get; set; }
        /// <summary>
        /// 成员账户名称	非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string MEMACCTNAME { get; set; }
        /// <summary>
        /// 上存积数，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALUPSCORE { get; set; }
        /// <summary>
        /// 上存利率，Decimal(9,7)，百分比	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal UPRATIO { get; set; }
        /// <summary>
        /// 手工调整上存利息，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal ADJUSTUPINTEREST { get; set; }
        /// <summary>
        /// 透支积数，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal TOTALDOWNSCORE { get; set; }
        /// <summary>
        /// 透支利率，Decimal(9,7)，百分比	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal DOWNRATIO { get; set; }
        /// <summary>
        /// 手工调整透支利息，Decimal(17,2) 透支利息只可改小，不可改大 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal ADJUSTDOWNINTEREST { get; set; }
        /// <summary>
        /// 货币种类 参考附件“货币种类编码”中的货币种类编码 非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
