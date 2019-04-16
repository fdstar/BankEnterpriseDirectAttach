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
    /// 23.11.临时额度取消请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_11 : CMBBase<RQINFO>, IRequest<RS23_11>
    {
        /// <summary>
        /// NTCPRAUC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRAUC";
        /// <summary>
        /// 23.11.临时额度取消请求内容
        /// </summary>
        public NTCPRCRDX NTCPRCRDX { get; set; }
    }
}
