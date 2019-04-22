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
    /// 8.9.5.个股期权转账交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_9_5 : CMBBase<RQINFO>, IRequest<RS8_9_5>
    {
        /// <summary>
        /// NTQSGDQR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQSGDQR";
        /// <summary>
        /// 8.9.5.个股期权转账交易查询请求内容
        /// </summary>
        public NTSECDQRX NTSECDQRX { get; set; }
    }
}
