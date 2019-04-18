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
    /// 8.4.16.网上转网下申请取消响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_16 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNCCAP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNCCAP";
    }
}
