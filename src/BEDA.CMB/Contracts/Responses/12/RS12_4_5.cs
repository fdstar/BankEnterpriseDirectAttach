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
    /// 12.4.5.支付机构经办汇入汇款母业务响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_4_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIRAJZP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRAJZP";
        /// <summary>
        /// 12.4.5.支付机构经办汇入汇款母业务响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
