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
    /// 26.9.修改经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_9 : CMBBase<RQINFO>, IRequest<RS26_9>
    {
        /// <summary>
        /// NTECKOPRUPD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKOPRUPD";
        /// <summary>
        /// 26.9.修改经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 26.9.修改经办请求内容
        /// </summary>
        public NTECKOPRX NTECKOPRX { get; set; }
        /// <summary>
        /// 26.9.修改经办请求内容
        /// </summary>
        public NTECKRCVX NTECKRCVX { get; set; }
    }
}
