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
    /// 3.6.直接支付响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// DCPAYMNT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCPAYMNT";
        /// <summary>
        /// 3.6.直接支付响应集合
        /// </summary>
        [XmlElement("NTQPAYRQZ")]
        public List<NTQPAYRQZ> List { get; set; }
    }
}
