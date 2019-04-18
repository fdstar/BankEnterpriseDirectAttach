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
    /// 8.3.6.理财产品赎回经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDSOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDSOPR";
        /// <summary>
        /// 8.3.6.理财产品赎回经办响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
}
