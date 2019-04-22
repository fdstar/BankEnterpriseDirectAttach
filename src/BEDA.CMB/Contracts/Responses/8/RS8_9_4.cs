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
    /// 8.9.4.个股期权查询券商编号及保证金响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_9_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCNVQSG
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCNVQSG";
        /// <summary>
        /// 8.9.4.个股期权查询券商编号及保证金响应集合
        /// </summary>
        [XmlElement("NTSECCNVZ2")]
        public List<NTSECCNVZ2> List { get; set; }
    }
}
