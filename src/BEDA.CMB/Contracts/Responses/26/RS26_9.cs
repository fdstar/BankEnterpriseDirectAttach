using BEDA.Utils;
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
    /// 26.9.修改经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKOPRUPD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKOPRUPD";
        /// <summary>
        /// 26.9.修改经办响应集合
        /// </summary>
        public NTECKOPRZ NTECKOPRZ { get; set; }
    }
}
