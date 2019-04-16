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
    /// 23.5.取公司卡历史交易响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRTRH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRTRH";
        /// <summary>
        /// 23.5.取公司卡历史交易响应集合
        /// </summary>
        [XmlElement("NTCPRTRSZ")]
        public List<NTCPRTRSZ> List { get; set; }
    }
}
