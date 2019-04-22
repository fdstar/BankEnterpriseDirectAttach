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
    /// 8.10.4.融资融券查询保证金账户响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_10_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCNVRZQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCNVRZQ";
        /// <summary>
        /// 8.10.4.融资融券查询保证金账户响应集合
        /// </summary>
        [XmlElement("NTSECCNVZ2")]
        public List<NTSECCNVZ2> List { get; set; }
    }
}
