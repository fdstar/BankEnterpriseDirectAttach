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
    /// 10.20.查询子公司点差利率响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_20 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLIRFRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRFRT";
        /// <summary>
        /// 10.20.查询子公司点差利率响应内容
        /// </summary>
        public NTLIRFRTZ NTLIRFRTZ { get; set; }
    }
    /// <summary>
    /// 10.20.查询子公司点差利率响应内容
    /// </summary>
    public class NTLIRFRTZ
    {
        /// <summary>
        /// 上存点差利率	I
        /// </summary>
        public decimal CRDINR { get; set; }
        /// <summary>
        /// 下借点差利率	I
        /// </summary>
        public decimal DBTINR { get; set; }
        /// <summary>
        /// 上存利率	I
        /// </summary>
        public decimal CRDINV { get; set; }
        /// <summary>
        /// 下借利率	I
        /// </summary>
        public decimal DBTINV { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
