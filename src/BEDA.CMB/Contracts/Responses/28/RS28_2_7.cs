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
    /// 28.2.7.定期支取（实时结息）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMHDTE
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMHDTE";
        /// <summary>
        /// 28.2.7.定期支取（实时结息）响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}