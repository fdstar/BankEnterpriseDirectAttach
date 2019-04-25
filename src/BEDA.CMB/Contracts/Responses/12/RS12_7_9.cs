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
    /// 12.7.9.查询支付机构外汇集中收付业务模式适用资源及控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTJZPCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJZPCTL";
        /// <summary>
        /// 12.7.9.查询支付机构外汇集中收付业务模式适用资源及控制信息响应集合
        /// </summary>
        [XmlElement("NTOPRFCTZ")]
        public List<NTOPRFCTZ> List { get; set; }
    }
}
