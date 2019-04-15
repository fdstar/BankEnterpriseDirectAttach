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
    /// 19.3.6.电子商票托收经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKRMCHOR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRMCHOR";
        /// <summary>
        /// 19.3.6.电子商票托收经办响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
