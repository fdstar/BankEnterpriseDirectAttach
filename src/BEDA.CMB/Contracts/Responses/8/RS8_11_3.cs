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
    /// 8.11.3.查询保证金余额响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_11_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBTFBAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFBAL";
        /// <summary>
        /// 8.11.3.查询保证金余额响应集合
        /// </summary>
        [XmlElement("NTSECBALZ")]
        public List<NTSECBALZ> List { get; set; }
    }
}
