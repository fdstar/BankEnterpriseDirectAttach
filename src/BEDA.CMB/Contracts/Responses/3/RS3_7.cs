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
    /// 3.7.直接内转响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// DCOPRTRF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCOPRTRF";
        /// <summary>
        /// 3.7.直接内转响应集合
        /// </summary>
        [XmlElement("NTQPAYRQZ")]
        public List<NTQPAYRQZ> List { get; set; }
    }
}
