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
    /// 22.1.9.纸质汇票委托收款申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_1_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILRCD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILRCD";
    }
}
