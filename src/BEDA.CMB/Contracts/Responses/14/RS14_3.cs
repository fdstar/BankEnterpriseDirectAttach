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
    /// 14.3.大额划拨经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS14_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTOPRFMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTOPRFMT";
    }
}
