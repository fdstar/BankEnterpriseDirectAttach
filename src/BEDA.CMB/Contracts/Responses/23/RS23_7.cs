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
    /// 23.7.批量消费额度设置响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRLMM
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLMM";
        /// <summary>
        /// 23.7.批量消费额度设置响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
