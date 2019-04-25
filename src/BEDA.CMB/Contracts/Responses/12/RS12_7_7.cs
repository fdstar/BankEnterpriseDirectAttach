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
    /// 12.7.7.汇出汇款经办查询模式适用资源及控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRMCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRMCTL";
        /// <summary>
        /// 12.7.7.汇出汇款经办查询模式适用资源及控制信息响应集合
        /// </summary>
        [XmlElement("NTOPRACCZ")]
        public List<NTOPRACCZ> List { get; set; }
    }
}
