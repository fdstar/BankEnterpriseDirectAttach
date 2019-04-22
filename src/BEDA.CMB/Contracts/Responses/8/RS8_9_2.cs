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
    /// 8.9.2.个股期权直联综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_9_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQSGDQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQSGDQY";
        /// <summary>
        /// 8.9.2.个股期权直联综合查询响应集合
        /// </summary>
        [XmlElement("NTSECDQYZ")]
        public List<NTSECDQYZ> List { get; set; }
    }
}
