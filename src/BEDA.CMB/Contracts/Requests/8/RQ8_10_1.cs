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
    /// 8.10.1.融资融券转账经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_10_1 : CMBBase<RQINFO>, IRequest<RS8_10_1>
    {
        /// <summary>
        /// NTOPRRZQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRRZQ";
        /// <summary>
        /// 8.10.1.融资融券转账经办请求内容
        /// </summary>
        public NTSECOPRX NTSECOPRX { get; set; }
        /// <summary>
        /// 8.10.1.融资融券转账经办请求内容
        /// </summary>
        public NTSECOPRX1 NTSECOPRX1 { get; set; }
    }
}
