using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.17.2内部计价利息分配请求主体
    /// </summary>
    public class V1_DCPINTERESTADJUSTTRNRQ : IRequest<V1_DCPINTERESTADJUSTTRNRS>
    {
        /// <summary>
        /// 3.17.2内部计价利息分配请求主体
        /// </summary>
        public DCPINTERESTADJUSTTRNRQ DCPINTERESTADJUSTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.2内部计价利息分配请求主体
    /// </summary>
    public class DCPINTERESTADJUSTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.2内部计价利息分配请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DCPINTERESTADJUSTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.2内部计价利息分配请求内容
    /// </summary>
    public class DCPINTERESTADJUSTTRN_RQBODY
    {
        /// <summary>
        /// 主账户账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 成员活期账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MEMACCTNO { get; set; }
        /// <summary>
        /// 活期担保积数，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal CURRFUND { get; set; }
        /// <summary>
        /// 活期担保利息，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal CURRINTRST { get; set; }
        /// <summary>
        /// 活期担保利率，Decimal(9,7)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal CURRINTRSTRATE { get; set; }
        /// <summary>
        /// 手工调整（实际）活期担保利息，Decimal(17,2) ，默认与活期担保利息一致，也可进行修改	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal ADJUSTDEMANDINTRST { get; set; }
        /// <summary>
        /// 定期担保积数，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal TIMEFUND { get; set; }
        /// <summary>
        /// 定期担保利息，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal TIMEINTRST { get; set; }
        /// <summary>
        /// 定期担保利率，Decimal(9,7)	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal TIMEINTRSTRATE { get; set; }
        /// <summary>
        /// 手工调整（实际）定期担保利息，Decimal(17,2),默认与定期担保利息一致，也可进行修改	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal ADJUSTTIMEINTRST { get; set; }
        /// <summary>
        /// 货币符号RMB，目前仅支持RMB	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string CURSYM { get; set; }
    }
}
