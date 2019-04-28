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
    /// 25.4.还款利息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS25_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCDTINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTINT";
        /// <summary>
        /// 25.4.还款利息查询响应内容
        /// </summary>
        public NTCDTINTZ1 NTCDTINTZ1 { get; set; }
    }
    /// <summary>
    /// 25.4.还款利息查询响应内容
    /// </summary>
    public class NTCDTINTZ1
    {
        /// <summary>
        /// 还款金额	M
        /// </summary>
        public decimal PYOAMT { get; set; }
        /// <summary>
        /// 匹配利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 保留字30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
