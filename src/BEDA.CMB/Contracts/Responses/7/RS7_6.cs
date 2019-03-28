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
    /// 7.6.委贷借款确认请求响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRACK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRACK";
        /// <summary>
        /// 7.6.委贷借款确认请求响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
