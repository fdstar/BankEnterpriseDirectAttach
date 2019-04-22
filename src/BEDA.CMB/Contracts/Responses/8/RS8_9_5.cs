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
    /// 8.9.5.个股期权转账交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_9_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQSGDQR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQSGDQR";
        /// <summary>
        /// 8.9.5.个股期权转账交易查询响应集合
        /// </summary>
        [XmlElement("NTSECDQRZ")]
        public List<NTSECDQRZ> List { get; set; }
    }
}
