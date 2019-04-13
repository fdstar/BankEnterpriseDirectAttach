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
    /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKECPSET
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKECPSET";
        /// <summary>
        /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
