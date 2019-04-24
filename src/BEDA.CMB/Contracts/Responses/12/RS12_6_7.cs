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
    /// 12.6.7.支付机构查询实时购结汇项下子业务明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_6_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTEXDQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXDQRT";
        /// <summary>
        /// 12.6.7.支付机构查询实时购结汇项下子业务明细响应内容
        /// </summary>
        public NTJSBQRTZ NTJSBQRTZ { get; set; }
        /// <summary>
        /// 12.6.7.支付机构查询实时购结汇项下子业务明细响应集合
        /// </summary>
        [XmlElement("NTBEXQRTZ")]
        public List<NTBEXQRTZ> NTBEXQRTZList { get; set; }
        /// <summary>
        /// 12.6.7.支付机构查询实时购结汇项下子业务明细响应集合
        /// </summary>
        [XmlElement("NTVENQRTZ")]
        public List<NTVENQRTZ> NTVENQRTZList { get; set; }
    }
}
