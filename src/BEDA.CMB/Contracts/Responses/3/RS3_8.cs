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
    /// 3.8.支付经办（需要网银审批）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// DCPAYREQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCPAYREQ";
        /// <summary>
        /// 3.8.支付经办（需要网银审批）响应集合
        /// </summary>
        [XmlElement("NTQPAYRQZ")]
        public List<NTQPAYRQZ> List { get; set; }
    }
}
