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
    /// 19.3.10.电子商票托收信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKMCHRCV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMCHRCV";
        /// <summary>
        /// 19.3.10.电子商票托收信息查询响应集合
        /// </summary>
        [XmlElement("NTMCHLITZ")]
        public List<NTMCHLITZ> List { get; set; }
    }
}
