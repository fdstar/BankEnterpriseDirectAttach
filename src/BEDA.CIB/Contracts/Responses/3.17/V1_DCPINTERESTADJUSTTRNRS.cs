using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.17.2内部计价利息分配响应主体
    /// </summary>
    public class V1_DCPINTERESTADJUSTTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.2内部计价利息分配响应主体
        /// </summary>
        public DCPINTERESTADJUSTTRNRS DCPINTERESTADJUSTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.2内部计价利息分配响应主体
    /// </summary>
    public class DCPINTERESTADJUSTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.2内部计价利息分配响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DCPINTERESTADJUSTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.2内部计价利息分配响应内容
    /// </summary>
    public class DCPINTERESTADJUSTTRN_RSBODY
    {
        /// <summary>
        /// 主账户账户代号，18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 主账号名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCTNAME { get; set; }
        /// <summary>
        /// 成员活期账户代号，18位
        /// </summary>
        [XmlElement(Order = 2)]
        public string MEMACCTNO { get; set; }
        /// <summary>
        /// 成员账号名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string MEMACCTNAME { get; set; }
        /// <summary>
        /// 活期担保积数，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal CURRFUND { get; set; }
        /// <summary>
        /// 活期担保利息，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal CURRINTRST { get; set; }
        /// <summary>
        /// 活期担保利率，Decimal(9,7)
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal CURRINTRSTRATE { get; set; }
        /// <summary>
        /// 实际活期担保利息，Decimal(17,2) 
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal ADJUSTDEMANDINTRST { get; set; }
        /// <summary>
        /// 定期担保积数，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal TIMEFUND { get; set; }
        /// <summary>
        /// 定期担保利息，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal TIMEINTRST { get; set; }
        /// <summary>
        /// 定期担保利率，Decimal(9,7)
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal TIMEINTRSTRATE { get; set; }
        /// <summary>
        /// 实际定期担保利息，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal ADJUSTTIMEINTRST { get; set; }
        /// <summary>
        /// 货币符号RMB，目前仅支持RMB	非必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 批量指令处理状态
        /// </summary>
        [XmlElement(Order = 13)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
