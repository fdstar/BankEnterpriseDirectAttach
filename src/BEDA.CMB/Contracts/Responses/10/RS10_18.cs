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
    /// 10.18.大额资金划拨响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_18 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLLMBRP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLLMBRP";
        /// <summary>
        /// 10.18.大额资金划拨响应内容
        /// </summary>
        public NTLLMBRPZ NTLLMBRPZ { get; set; }
    }
    /// <summary>
    /// 10.18.大额资金划拨响应内容
    /// </summary>
    public class NTLLMBRPZ
    {
        /// <summary>
        /// 可用余额      	M
        /// </summary>
        public decimal AVLBAL { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
