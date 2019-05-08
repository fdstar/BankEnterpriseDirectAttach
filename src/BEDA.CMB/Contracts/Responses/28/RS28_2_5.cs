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
    /// 28.2.5.虚拟户退款经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRDMR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRDMR";
        /// <summary>
        /// 28.2.5.虚拟户退款经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
