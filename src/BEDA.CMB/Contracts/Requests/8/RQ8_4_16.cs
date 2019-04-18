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
    /// 8.4.16.网上转网下申请取消请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_16 : CMBBase<RQINFO>, IRequest<RS8_4_16>
    {
        /// <summary>
        /// NTFNCCAP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNCCAP";
        /// <summary>
        /// 8.4.16.网上转网下申请取消请求内容
        /// </summary>
        public NTFNCCAPX NTFNCCAPX { get; set; }
    }
    /// <summary>
    /// 8.4.16.网上转网下申请取消请求内容
    /// </summary>
    public class NTFNCCAPX
    {
        /// <summary>
        /// 活期账号分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 定期帐号分行号	C(2)	附录A.1
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
