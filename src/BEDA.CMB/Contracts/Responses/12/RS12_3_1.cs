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
    /// 12.3.1.支付机构经办汇出汇款申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_3_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTOPRRTA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTOPRRTA";
        /// <summary>
        /// 12.3.1.支付机构经办汇出汇款申请响应内容
        /// </summary>
        public NTLCARTNZ NTLCARTNZ { get; set; }
    }
}