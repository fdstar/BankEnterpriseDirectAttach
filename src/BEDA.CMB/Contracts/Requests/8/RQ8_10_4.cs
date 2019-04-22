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
    /// 8.10.4.融资融券查询保证金账户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_10_4 : CMBBase<RQINFO>, IRequest<RS8_10_4>
    {
        /// <summary>
        /// NTCNVRZQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCNVRZQ";
        /// <summary>
        /// 8.10.4.融资融券查询保证金账户请求内容
        /// </summary>
        public NTSECCNVX NTSECCNVX { get; set; }
    }
}
