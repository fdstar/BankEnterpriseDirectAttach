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
    /// 8.9.2.个股期权直联综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_9_2 : CMBBase<RQINFO>, IRequest<RS8_9_2>
    {
        /// <summary>
        /// NTQSGDQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQSGDQY";
        /// <summary>
        /// 8.9.2.个股期权直联综合查询请求内容
        /// </summary>
        public NTSECDQYX NTSECDQYX { get; set; }
    }
}
