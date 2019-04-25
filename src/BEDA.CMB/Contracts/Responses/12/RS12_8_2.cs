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
    /// 12.8.2.支付机构撤销结售汇申请项下明细数据响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_8_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTJSHDCL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSHDCL";
    }
}
