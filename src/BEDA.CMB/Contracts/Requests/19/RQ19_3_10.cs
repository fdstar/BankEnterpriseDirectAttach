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
    /// 19.3.10.电子商票托收信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_10 : CMBBase<RQINFO>, IRequest<RS19_3_10>
    {
        /// <summary>
        /// SDKMCHRCV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMCHRCV";
        /// <summary>
        /// 19.3.10.电子商票托收信息查询请求内容
        /// </summary>
        public NTDRFRCVX NTDRFRCVX { get; set; }
    }
}
