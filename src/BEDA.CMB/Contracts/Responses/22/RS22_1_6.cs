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
    /// 22.1.6.纸质商业汇票托管申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_1_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILHSD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILHSD";
    }
}
