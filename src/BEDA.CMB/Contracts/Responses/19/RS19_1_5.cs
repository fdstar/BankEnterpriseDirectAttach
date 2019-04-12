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
    /// 19.1.5.自动托收协议维护响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_1_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKRCVADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKRCVADD";
    }
}
