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
    /// 8.10.1.融资融券转账经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_10_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRRZQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRRZQ";
        /// <summary>
        /// 8.10.1.融资融券转账经办响应内容
        /// </summary>
        public NTFNDRTNZ1 NTFNDRTNZ1 { get; set; }
    }
}
