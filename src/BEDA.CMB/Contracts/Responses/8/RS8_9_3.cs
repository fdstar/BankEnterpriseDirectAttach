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
    /// 8.9.3.券商个股期权查询券商保证金响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_9_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQSGBAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQSGBAL";
        /// <summary>
        /// 8.9.3.券商个股期权查询券商保证金响应集合
        /// </summary>
        [XmlElement("NTSECBALZ")]
        public List<NTSECBALZ> List { get; set; }
    }
}
