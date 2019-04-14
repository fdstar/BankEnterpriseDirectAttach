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
    /// 19.2.10.撤销托管申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKPMGOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKPMGOPR";
        /// <summary>
        /// 19.2.10.撤销托管申请响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
