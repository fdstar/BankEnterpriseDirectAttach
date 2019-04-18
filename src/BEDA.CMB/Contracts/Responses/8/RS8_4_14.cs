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
    /// 8.4.14.网上转网下申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_14 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNCAPP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNCAPP";
    }
}
