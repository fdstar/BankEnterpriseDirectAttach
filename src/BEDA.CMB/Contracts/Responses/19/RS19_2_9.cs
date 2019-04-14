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
    /// 19.2.9.电子票退票经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKQUTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKQUTOPR";
        /// <summary>
        /// 19.2.9.电子票退票经办响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
