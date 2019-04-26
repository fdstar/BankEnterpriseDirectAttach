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
    /// 12.10.3.离岸外汇汇款经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_10_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTRTOOP3
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTOOP3";
        /// <summary>
        /// 12.10.3.离岸外汇汇款经办响应内容
        /// </summary>
        public NTRTARTNZ NTRTARTNZ { get; set; }
    }
}
