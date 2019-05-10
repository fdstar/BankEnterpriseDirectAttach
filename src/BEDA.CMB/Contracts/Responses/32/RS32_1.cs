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
    /// 32.1.国际信用证开证经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS32_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRLCB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRLCB";
        /// <summary>
        /// 32.1.国际信用证开证经办响应内容
        /// </summary>
        public NTLCARTNZ NTLCARTNZ { get; set; }
    }
}
