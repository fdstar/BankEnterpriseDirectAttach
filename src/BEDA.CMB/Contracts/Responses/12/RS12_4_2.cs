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
    /// 12.4.2.支付机构确认汇入汇款属性响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_4_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIRAOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRAOPR";
        /// <summary>
        /// 12.4.2.支付机构确认汇入汇款属性响应集合
        /// </summary>
        [XmlElement("NTOPRRTNZ")]
        public List<NTOPRRTNZ> List { get; set; }
    }
}
