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
    /// 19.3.12.查询机构号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKDPTNBR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKDPTNBR";
        /// <summary>
        /// 19.3.12.查询机构号响应集合
        /// </summary>
        [XmlElement("NTMNUDSPZ")]
        public List<NTMNUDSPZ> List { get; set; }
    }
}
