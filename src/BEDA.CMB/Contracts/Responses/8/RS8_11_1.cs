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
    /// 8.11.1.银期转账经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_11_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBTFOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFOPR";
        /// <summary>
        /// 8.11.1.银期转账经办响应内容
        /// </summary>
        public NTFNDRTNZ1 NTFNDRTNZ1 { get; set; }
    }
}
