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
    /// 23.22.公司卡解除中止业务（解锁）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_22 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLCKRLS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLCKRLS";
        /// <summary>
        /// 23.22.公司卡解除中止业务（解锁）响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
