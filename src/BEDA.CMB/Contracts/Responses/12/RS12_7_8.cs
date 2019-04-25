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
    /// 12.7.8.查询汇入汇款确认业务模式适用资源及控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIRACTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRACTL";
        /// <summary>
        /// 12.7.8.查询汇入汇款确认业务模式适用资源及控制信息响应集合
        /// </summary>
        [XmlElement("NTOPRFCTZ")]
        public List<NTOPRFCTZ> List { get; set; }
    }
}
