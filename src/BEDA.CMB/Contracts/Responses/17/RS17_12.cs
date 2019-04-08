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
    /// 17.12.虚拟户利息试算响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMAINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAINT";
        /// <summary>
        /// 17.12.虚拟户利息试算响应内容
        /// </summary>
        public NTDMAINTZ1 NTDMAINTZ1 { get; set; }
    }
    /// <summary>
    /// 17.12.虚拟户利息试算响应内容
    /// </summary>
    public class NTDMAINTZ1
    {
        /// <summary>
        /// 计息积数	F(17,2)
        /// </summary>
        public decimal INTAUB { get; set; }
        /// <summary>
        /// 试算利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利息方向	C(1)	D:借方 C:贷方
        /// </summary>
        public string TRXDIR { get; set; }
    }
}
