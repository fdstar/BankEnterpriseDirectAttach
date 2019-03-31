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
    /// 11.4.查询代理清算批量经办处理结果响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS11_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQAPRST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQAPRST";
        /// <summary>
        /// 11.4.查询代理清算批量经办处理结果响应集合
        /// </summary>
        [XmlElement("NTOPRAGPX1")]
        public List<Requests.NTOPRAGPX1> NTOPRAGPX1List { get; set; }
        /// <summary>
        /// 11.4.查询代理清算批量经办处理结果响应集合
        /// </summary>
        [XmlElement("NTAGPRTNZ")]
        public List<NTAGPRTNZ> NTAGPRTNZList { get; set; }
    }
}
