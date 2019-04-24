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
    /// 12.6.6.支付机构查询实时购结汇项下子业务上传批次列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_6_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTEXCBLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXCBLT";
        /// <summary>
        /// 12.6.6.支付机构查询实时购结汇项下子业务上传批次列表响应集合
        /// </summary>
        [XmlElement("NTJSHBLTZ")]
        public List<NTJSHBLTZ> List { get; set; }
    }
}
