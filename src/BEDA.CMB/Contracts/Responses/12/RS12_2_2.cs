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
    /// 12.2.2.支付机构经办实时结汇响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_2_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPREXS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPREXS";
        /// <summary>
        /// 12.2.1.支付机构经办实时购汇响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
