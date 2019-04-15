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
    /// 22.1.2.贴现申请清单上传响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_1_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILDSC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILDSC";
    }
}
