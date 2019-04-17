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
    /// 23.16.取款密码重置响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_16 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRWPS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRWPS";
        /// <summary>
        /// 23.16.取款密码重置响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
