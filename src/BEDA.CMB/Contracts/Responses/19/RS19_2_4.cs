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
    /// 19.2.4.背书转让经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKWRTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKWRTOPR";
        /// <summary>
        /// 19.2.3.汇票批量签发经办（银行承兑、商业承兑同一程序）响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
