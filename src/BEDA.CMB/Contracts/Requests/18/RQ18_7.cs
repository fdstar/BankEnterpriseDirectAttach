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
    /// 18.7.境外账户查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_7 : CMBBase<RQINFO>, IRequest<RS18_7>
    {
        /// <summary>
        /// NTQRYCAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYCAC";
        /// <summary>
        /// 18.7.境外账户查询请求内容
        /// </summary>
        public NTQRYCACX NTQRYCACX { get; set; }
    }
    /// <summary>
    /// 18.7.境外账户查询请求内容
    /// </summary>
    public class NTQRYCACX
    {
        /// <summary>
        /// 行内账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 境外账号	C(35)
        /// </summary>
        public string CRSACC { get; set; }
    }
}
