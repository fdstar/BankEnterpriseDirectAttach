using BEDA.Utils;
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
    /// 26.1.取模式信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKCTL";
        /// <summary>
        /// 26.1.取模式信息响应集合
        /// </summary>
        [XmlElement("NTOPRFCTZ")]
        public List<NTOPRFCTZ> List { get; set; }
    }
}
