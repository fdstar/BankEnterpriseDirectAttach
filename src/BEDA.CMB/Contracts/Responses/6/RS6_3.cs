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
    /// 6.3.生成签名响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// Signature
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "Signature";
        /// <summary>
        /// 6.3.生成签名响应内容
        /// </summary>
        public SDKEMPAYZ SDKEMPAYZ { get; set; }
    }
    /// <summary>
    /// 6.3.生成签名响应内容
    /// </summary>
    public class SDKEMPAYZ
    {
        /// <summary>
        /// 签名结果	C
        /// </summary>
        public string RESULT { get; set; }
    }
}
