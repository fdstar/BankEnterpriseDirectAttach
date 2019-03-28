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
    /// 7.8.委贷还款经办请求响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRAPO
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRAPO";
        /// <summary>
        /// 7.8.委贷还款经办请求响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
