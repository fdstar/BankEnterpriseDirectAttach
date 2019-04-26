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
    /// 12.8.5.支付机构撤销汇出汇款申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_8_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTRTACNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTACNL";
    }
}
