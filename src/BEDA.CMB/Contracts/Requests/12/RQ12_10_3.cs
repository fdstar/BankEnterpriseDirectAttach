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
    /// 12.10.3.离岸外汇汇款经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_10_3 : CMBBase<RQINFO>, IRequest<RS12_10_3>
    {
        /// <summary>
        /// NTRTOOP3
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTOOP3";
        /// <summary>
        /// 12.10.3.离岸外汇汇款经办请求内容
        /// </summary>
        public NTRTOOPTX NTRTOOPTX { get; set; }
        /// <summary>
        /// 12.10.3.离岸外汇汇款经办请求内容
        /// </summary>
        public NTRTOOPRX NTRTOOPRX { get; set; }
    }
}
