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
    /// 28.2.11.大额划拨交易综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYGMD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYGMD";
        /// <summary>
        /// 28.2.11.大额划拨交易综合查询响应集合
        /// </summary>
        [XmlElement("NTGMTREDZ1")]
        public List<NTGMTREDZ1> List { get; set; }
    }
}
