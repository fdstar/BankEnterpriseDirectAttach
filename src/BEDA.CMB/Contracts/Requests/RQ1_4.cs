using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 1.4.取新的通知请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ1_4 : CMBBase<RQINFO>, IRequest<RS1_4>
    {
        /// <summary>
        /// GetNewNotice
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetNewNotice";
    }
}
