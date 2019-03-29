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
    /// 10.8.基准利率维护响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLIRBMN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLIRBMN";
    }
}
