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
    /// 8.3.9.当日委托撤单响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDICAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDICAL";
    }
}
