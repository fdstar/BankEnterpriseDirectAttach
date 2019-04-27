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
    /// 25.3.还款业务经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS25_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCDTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTOPR";
        /// <summary>
        /// 25.3.还款业务经办响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
