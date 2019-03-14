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
    /// 4.10.代发结果列表查询-按业务参考号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGCINY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCINY";
        /// <summary>
        /// 4.10.代发结果列表查询-按业务参考号响应集合
        /// </summary>
        [XmlElement("NTAGCINQZ")]
        public List<NTAGCINQZ> List { get; set; }
    }
}
