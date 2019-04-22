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
    /// 12.1.1.支付机构经办结售汇申请响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_1_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRJSH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRJSH";
        /// <summary>
        /// 12.1.1.支付机构经办结售汇申请响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
