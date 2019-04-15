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
    /// 19.3.7.电子商票信息综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKMDFINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMDFINQ";
        /// <summary>
        /// 19.3.7.电子商票信息综合查询响应集合
        /// </summary>
        [XmlElement("NTMCHLITZ")]
        public List<NTMCHLITZ> List { get; set; }
    }
}
