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
    /// 26.7.批量作废经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKMOPDEL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKMOPDEL";
        /// <summary>
        /// 26.7.批量作废经办响应集合
        /// </summary>
        public NTECKMOPZ NTECKMOPZ { get; set; }
    }
}
