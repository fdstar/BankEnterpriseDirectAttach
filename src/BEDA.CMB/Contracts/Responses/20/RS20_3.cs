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
    /// 20.3.联动支付经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS20_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRLKP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRLKP";
        /// <summary>
        /// 20.3.联动支付经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
