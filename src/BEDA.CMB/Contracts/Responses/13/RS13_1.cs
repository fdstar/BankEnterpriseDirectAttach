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
    /// 13.1.增加支付限额协议响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS13_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTLMTADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTLMTADD";
    }
}
