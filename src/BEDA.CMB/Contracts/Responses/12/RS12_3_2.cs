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
    /// 12.3.2.支付机构上传汇款业务项下支出明细数据响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_3_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPAYOUT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYOUT";
        /// <summary>
        /// 12.3.2.支付机构上传汇款业务项下支出明细数据响应集合
        /// </summary>
        [XmlElement("NTPAYMSGZ1")]
        public List<NTPAYMSGZ1> List { get; set; }
    }
}
