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
    /// 6.13.采购分离平台订单推送响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_13 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTORDSND
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTORDSND";
    }
}
