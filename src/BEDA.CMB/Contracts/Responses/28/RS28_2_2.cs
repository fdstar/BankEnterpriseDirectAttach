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
    /// 28.2.2.虚拟户历史交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMTQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTQRY";
        /// <summary>
        /// 28.2.2.虚拟户历史交易查询响应集合
        /// </summary>
        [XmlElement("NTDMTQRYZ1")]
        public List<NTDMTQRYZ1> List { get; set; }
    }
}
