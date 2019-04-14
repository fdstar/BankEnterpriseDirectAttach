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
    /// 19.2.11.提前兑付经办票据信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKASHINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKASHINQ";
        /// <summary>
        /// 19.2.11.提前兑付经办票据信息查询响应集合
        /// </summary>
        [XmlElement("NTDRFLSTZ")]
        public List<NTDRFLSTZ> List { get; set; }
    }
}
