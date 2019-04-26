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
    /// 12.10.2.离岸外汇汇款经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_10_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTRTOOP2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTOOP2";
        /// <summary>
        /// 12.10.2.离岸外汇汇款经办响应内容
        /// </summary>
        public NTRTARTNZ NTRTARTNZ { get; set; }
    }
}
