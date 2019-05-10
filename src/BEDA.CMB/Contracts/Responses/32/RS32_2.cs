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
    /// 32.2.国际信用证综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS32_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYLCD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCD";
        /// <summary>
        /// 32.2.国际信用证综合查询响应集合
        /// </summary>
        [XmlElement("NTLCALSTZ1")]
        public List<NTLCALSTZ1> List { get; set; }
    }
}
