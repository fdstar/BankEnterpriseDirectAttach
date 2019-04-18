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
    /// 8.4.10.取消通知响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSMACNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMACNL";
    }
}
