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
    /// 23.6.消费额度设置响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRLMS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLMS";
        /// <summary>
        /// 23.6.消费额度设置响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
