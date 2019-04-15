using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 19.3.7.电子商票信息综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_7 : CMBBase<RQINFO>, IRequest<RS19_3_7>
    {
        /// <summary>
        /// SDKMDFINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMDFINQ";
        /// <summary>
        /// 19.3.7.电子商票信息综合查询请求内容
        /// </summary>
        public NTMAGINQX NTMAGINQX { get; set; }
    }
}
