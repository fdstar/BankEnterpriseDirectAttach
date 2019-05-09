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
    /// 28.2.10.大额划拨经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRGMD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRGMD";
        /// <summary>
        /// 28.2.10.大额划拨经办响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}