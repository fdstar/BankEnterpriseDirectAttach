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
    /// 10.5.子公司现金池当天交易查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCASTDT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCASTDT";
        /// <summary>
        /// 10.5.子公司现金池当天交易查询响应集合
        /// </summary>
        [XmlElement("NTTRXSTRZ")]
        public List<NTTRXSTRZ> List { get; set; }
    }
}
