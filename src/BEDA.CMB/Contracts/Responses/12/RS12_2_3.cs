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
    /// 12.2.3.支付机构上传实时购结汇项下购汇明细数据响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_2_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPAYVEN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYVEN";
        /// <summary>
        /// 12.2.3.支付机构上传实时购结汇项下购汇明细数据响应集合
        /// </summary>
        [XmlElement("NTPAYMSGZ1")]
        public List<NTPAYMSGZ1> List { get; set; }
    }
}
