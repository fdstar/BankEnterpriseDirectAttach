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
    /// 8.10.5.融资融券转账交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_10_5 : CMBBase<RQINFO>, IRequest<RS8_10_5>
    {
        /// <summary>
        /// NTRZQDQR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRZQDQR";
        /// <summary>
        /// 8.10.5.融资融券转账交易查询请求内容
        /// </summary>
        public NTSECDQRX NTSECDQRX { get; set; }
    }
}
