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
    /// 19.3.8.电子商票交易信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKMCHTRS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMCHTRS";
        /// <summary>
        /// 19.3.8.电子商票交易信息查询响应集合
        /// </summary>
        [XmlElement("NTCUSTRSZ")]
        public List<NTCUSTRSZ> List { get; set; }
    }
}
