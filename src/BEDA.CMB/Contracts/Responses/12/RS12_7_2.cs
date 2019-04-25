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
    /// 12.7.2.支付机构查询客户号信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTJSHCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSHCTL";
        /// <summary>
        /// 12.7.2.支付机构查询客户号信息响应集合
        /// </summary>
        [XmlElement("NTOPRFCTZ")]
        public List<NTOPRFCTZ> List { get; set; }
    }
}
