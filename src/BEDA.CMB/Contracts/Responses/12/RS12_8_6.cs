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
    /// 12.8.6.支付机构撤销汇款类业务项下明细数据响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_8_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPAYDCL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYDCL";
    }
}
