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
    /// 19.3.2.经办电子商票据信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_2 : CMBBase<RQINFO>, IRequest<RS19_3_2>
    {
        /// <summary>
        /// SDKOMHINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKOMHINQ";
        /// <summary>
        /// 19.3.2.经办电子商票据信息查询请求内容
        /// </summary>
        public NTOPRINQX NTOPRINQX { get; set; }
    }
}
