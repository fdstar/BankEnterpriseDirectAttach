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
    /// 32.5.国际信用证单笔查询-按业务参考号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS32_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYLCY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCY";
        /// <summary>
        /// 32.5.国际信用证单笔查询-按业务参考号响应集合
        /// </summary>
        [XmlElement("NTLCALSTZ1")]
        public List<NTLCALSTZ1> List { get; set; }
    }
}
