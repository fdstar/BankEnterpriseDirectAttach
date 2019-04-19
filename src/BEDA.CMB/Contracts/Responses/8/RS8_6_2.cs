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
    /// 8.6.2.关联智能定期存款经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMARLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMARLT";
        /// <summary>
        /// 8.6.2.关联智能定期存款经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
