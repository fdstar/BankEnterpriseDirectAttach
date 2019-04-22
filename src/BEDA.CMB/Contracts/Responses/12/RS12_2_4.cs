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
    /// 12.2.4.支付机构上传实时购结汇项下结汇明细数据响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_2_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPAYBEX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYBEX";
        /// <summary>
        /// 12.2.4.支付机构上传实时购结汇项下结汇明细数据响应集合
        /// </summary>
        [XmlElement("NTPAYMSGZ1")]
        public List<NTPAYMSGZ1> List { get; set; }
    }
}
