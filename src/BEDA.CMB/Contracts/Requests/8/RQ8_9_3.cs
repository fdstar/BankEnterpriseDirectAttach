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
    /// 8.9.3.券商个股期权查询券商保证金请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_9_3 : CMBBase<RQINFO>, IRequest<RS8_9_3>
    {
        /// <summary>
        /// NTQSGBAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQSGBAL";
        /// <summary>
        /// 8.9.3.券商个股期权查询券商保证金请求内容
        /// </summary>
        public NTSECBALX NTSECBALX { get; set; }
        /// <summary>
        /// 8.9.3.券商个股期权查询券商保证金请求内容
        /// </summary>
        public NTSECOPRX1 NTSECOPRX1 { get; set; }
    }
}
