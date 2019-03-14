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
    /// 3.11.支付结果列表查询-按业务参考号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYSTN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYSTN";
        /// <summary>
        /// 3.11.支付结果列表查询-按业务参考号响应集合
        /// </summary>
        [XmlElement("NTSTLLSTZ")]
        public List<NTSTLLSTZ> List { get; set; }
    }
}
