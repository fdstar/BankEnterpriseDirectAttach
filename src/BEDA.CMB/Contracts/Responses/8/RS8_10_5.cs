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
    /// 8.10.5.融资融券转账交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_10_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTRZQDQR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRZQDQR";
        /// <summary>
        /// 8.10.5.融资融券转账交易查询响应集合
        /// </summary>
        [XmlElement("NTSECDQRZ")]
        public List<NTSECDQRZ> List { get; set; }
    }
}
