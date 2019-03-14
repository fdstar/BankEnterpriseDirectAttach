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
    /// 4.7.大批量代发经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGCAPY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCAPY";
        /// <summary>
        /// 4.7.大批量代发经办响应内容
        /// </summary>
        public NTAGCAGCZ1 NTAGCAGCZ1 { get; set; }
    }
}
