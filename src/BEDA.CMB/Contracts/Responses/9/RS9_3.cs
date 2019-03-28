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
    /// 9.3.信用额度查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS9_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNETDZC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZC";
        /// <summary>
        /// 9.3.信用额度查询响应集合
        /// </summary>
        [XmlElement("NTNETDZCZ1")]
        public List<NTNETDZCZ1> List { get; set; }
    }
}
