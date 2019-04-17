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
    /// 8.2.7.智能现金池投资计划经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNPOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPOPR";
        /// <summary>
        /// 8.2.7.智能现金池投资计划经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
