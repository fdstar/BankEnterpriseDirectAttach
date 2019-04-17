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
    /// 8.2.4.基金留存定投计划列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_2_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNPPL2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPPL2";
        /// <summary>
        /// 8.2.4.基金留存定投计划列表查询响应集合
        /// </summary>
        [XmlElement("NTFNPPLSZ")]
        public List<NTFNPPLSZ> List { get; set; }
    }
}
