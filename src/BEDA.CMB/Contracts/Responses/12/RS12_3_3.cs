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
    /// 12.3.3.支付机构上传汇款类业务项下收入明细数据响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_3_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPAYRCV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYRCV";
        /// <summary>
        /// 12.3.3.支付机构上传汇款类业务项下收入明细数据响应集合
        /// </summary>
        [XmlElement("NTPAYMSGZ1")]
        public List<NTPAYMSGZ1> List { get; set; }
    }
}
