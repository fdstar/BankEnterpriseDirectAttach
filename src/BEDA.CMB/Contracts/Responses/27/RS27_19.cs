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
    /// 27.19.多级现金池当天综合交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_19 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLTRD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLTRD";
        /// <summary>
        /// 27.19.多级现金池当天综合交易查询响应集合
        /// </summary>
        [XmlElement("NTMTLDTSZ1")]
        public List<NTMTLDTSZ1> List { get; set; }
    }
}
