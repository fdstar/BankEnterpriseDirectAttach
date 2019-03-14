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
    /// 4.8.大批量代扣经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGCACL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCACL";
        /// <summary>
        /// 4.8.大批量代扣经办响应内容
        /// </summary>
        public NTAGCAGCZ1 NTAGCAGCZ1 { get; set; }
    }
}
