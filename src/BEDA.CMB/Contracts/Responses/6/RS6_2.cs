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
    /// 6.2.验证签名响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// VerifySignature
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "VerifySignature";
    }
}
