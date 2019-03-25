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
    /// 21.4.1.网银借记响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_4_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIBDOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIBDOPR";
        /// <summary>
        /// 21.4.1.网银借记响应内容 等待时间
        /// </summary>
        public NTOPRDRTZ NTOPRDRTZ { get; set; }
        /// <summary>
        /// 21.4.1.网银借记响应集合
        /// </summary>
        [XmlElement("NTOPRRTNZ")]
        public List<NTOPRRTNZ> List { get; set; }
    }
}
