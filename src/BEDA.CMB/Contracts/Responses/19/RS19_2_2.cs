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
    /// 19.2.2.票据签发经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKECPOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKECPOPR";
        /// <summary>
        /// 19.2.2.票据签发经办响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
