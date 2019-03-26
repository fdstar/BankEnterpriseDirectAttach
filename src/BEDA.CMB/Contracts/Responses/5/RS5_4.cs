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
    /// 5.4.受益人查询来证（通知行）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS5_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYLCB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCB";
        /// <summary>
        /// 5.4.受益人查询来证（通知行）响应集合
        /// </summary>
        [XmlElement("NTLCALSTZ1")]
        public List<NTLCALSTZ1> List { get; set; }
    }
}
