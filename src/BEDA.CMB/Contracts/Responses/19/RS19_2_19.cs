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
    /// 19.2.19.票据退票查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_19 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKDRFQUT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKDRFQUT";
        /// <summary>
        /// 19.2.19.票据退票查询响应集合
        /// </summary>
        [XmlElement("NTMAGINQZ")]
        public List<NTMAGINQZ> List { get; set; }
    }
}
