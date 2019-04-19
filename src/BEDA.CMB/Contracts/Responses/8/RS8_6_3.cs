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
    /// 8.6.3.取消智能定期存款关联经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMARLD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMARLD";
        /// <summary>
        /// 8.6.3.取消智能定期存款关联经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
