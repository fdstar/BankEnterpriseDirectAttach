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
    /// 10.10.点差维护响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLIRFMN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRFMN";
    }
}
