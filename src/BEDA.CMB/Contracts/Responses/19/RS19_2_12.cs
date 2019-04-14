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
    /// 19.2.12.提前兑付经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKASHOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKASHOPR";
        /// <summary>
        /// 19.2.12.提前兑付经办响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
