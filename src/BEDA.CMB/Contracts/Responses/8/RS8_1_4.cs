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
    /// 8.1.4.开立基金账户NTFNDOAC响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_1_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNDOAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDOAC";
        /// <summary>
        /// 8.1.4.开立基金账户NTFNDOAC响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
