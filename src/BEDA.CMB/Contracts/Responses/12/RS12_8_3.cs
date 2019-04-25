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
    /// 12.8.3.支付机构撤销实时购结汇业务响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_8_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTEXCCNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXCCNL";
    }
}
