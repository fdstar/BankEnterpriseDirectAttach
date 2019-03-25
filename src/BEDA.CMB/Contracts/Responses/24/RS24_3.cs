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
    /// 24.3.网银电子对账经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS24_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNSTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTOPR";
        /// <summary>
        /// 24.3.网银电子对账经办响应集合
        /// </summary>
        [XmlElement("NTOPRRTNZ")]
        public List<NTOPRRTNZ> List { get; set; }
    }
}
