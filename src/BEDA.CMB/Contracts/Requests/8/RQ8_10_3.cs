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
    /// 8.10.3.融资融券查询券商保证金请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_10_3 : CMBBase<RQINFO>, IRequest<RS8_10_3>
    {
        /// <summary>
        /// NTRZQBAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRZQBAL";
        /// <summary>
        /// 8.10.3.融资融券查询券商保证金请求内容
        /// </summary>
        public NTSECBALX NTSECBALX { get; set; }
        /// <summary>
        /// 8.10.3.融资融券查询券商保证金请求内容
        /// </summary>
        public NTSECOPRX1 NTSECOPRX1 { get; set; }
    }
}
