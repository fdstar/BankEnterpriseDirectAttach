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
    /// 8.5.9.查询可申请转网下智能定期账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_5_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTTCAAPC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCAAPC";
        /// <summary>
        /// 8.5.9.查询可申请转网下智能定期账号响应集合
        /// </summary>
        [XmlElement("NTFNCAPCZ")]
        public List<NTFNCAPCZ> List { get; set; }
    }
}
