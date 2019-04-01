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
    /// 13.2.终止支付限额协议响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS13_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTLMTCNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTLMTCNL";
    }
}
