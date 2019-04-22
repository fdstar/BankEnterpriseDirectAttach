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
    /// 8.10.2.融资融券直联综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_10_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTRZQDQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRZQDQY";
        /// <summary>
        /// 8.10.2.融资融券直联综合查询响应集合
        /// </summary>
        [XmlElement("NTSECDQYZ")]
        public List<NTSECDQYZ> List { get; set; }
    }
}
