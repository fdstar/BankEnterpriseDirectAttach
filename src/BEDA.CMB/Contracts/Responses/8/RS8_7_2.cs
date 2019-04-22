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
    /// 8.7.2.归集存款内部转账经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_7_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMCOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMCOPR";
        /// <summary>
        /// 8.7.2.归集存款内部转账经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
