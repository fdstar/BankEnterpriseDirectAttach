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
    /// 19.2.13.托收申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_13 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKRCVOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRCVOPR";
        /// <summary>
        /// 19.2.13.托收申请响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
