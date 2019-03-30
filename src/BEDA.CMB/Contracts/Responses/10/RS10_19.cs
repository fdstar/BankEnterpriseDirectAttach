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
    /// 10.19.查询基准利率响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_19 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLIRBRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRBRT";
        /// <summary>
        /// 10.19.查询基准利率响应内容
        /// </summary>
        public NTLIRBRTZ NTLIRBRTZ { get; set; }
    }
    /// <summary>
    /// 10.19.查询基准利率响应内容
    /// </summary>
    public class NTLIRBRTZ
    {
        /// <summary>
        /// 基准利率	I
        /// </summary>
        public decimal BASINR { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
