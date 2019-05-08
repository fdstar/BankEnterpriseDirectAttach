using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 28.2.3.虚拟户交易利息试算响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMIQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMIQRY";
        /// <summary>
        /// 28.2.3.虚拟户交易利息试算响应内容
        /// </summary>
        public NTDMIQRYZ1 NTDMIQRYZ1 { get; set; }
    }
    /// <summary>
    /// 28.2.3.虚拟户交易利息试算响应内容
    /// </summary>
    public class NTDMIQRYZ1
    {
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DYANBR { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利率	F(11,7)
        /// </summary>
        public decimal INTVAL { get; set; }
        /// <summary>
        /// 计息金额	F(17,2)
        /// </summary>
        public decimal INTBAL { get; set; }
    }
}
