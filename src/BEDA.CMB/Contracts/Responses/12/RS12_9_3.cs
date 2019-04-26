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
    /// 12.9.3.支付机构申请建立商户单位基本情况表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_9_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBIFADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBIFADD";
    }
}
