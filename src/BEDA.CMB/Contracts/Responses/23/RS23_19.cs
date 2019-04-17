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
    /// 23.19.取公司结算户历史交易响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_19 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPATRH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPATRH";
        /// <summary>
        /// 23.19.取公司结算户历史交易响应集合
        /// </summary>
        [XmlElement("NTCPRTRSZ")]
        public List<NTCPRTRSZ> List { get; set; }
    }
}
