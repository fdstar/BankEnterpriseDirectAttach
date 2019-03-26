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
    /// 6.12.电票出票担保支付平台确认响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPLFNTF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPLFNTF";
    }
}
