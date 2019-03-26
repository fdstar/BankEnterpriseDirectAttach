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
    /// 6.14.平台撤销订单响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_14 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPLFCNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPLFCNL";
    }
}
