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
    /// 32.4.国际信用证修改申请经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS32_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRMDG
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRMDG";
        /// <summary>
        /// 32.4.国际信用证修改申请经办响应内容
        /// </summary>
        public NTLCARTNZ NTLCARTNZ { get; set; }
    }
}
