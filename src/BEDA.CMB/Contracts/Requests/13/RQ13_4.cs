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
    /// 13.4.查询支付限额协议请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ13_4 : CMBBase<RQINFO>, IRequest<RS13_4>
    {
        /// <summary>
        /// SDKNTQRYLMT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYLMT";
        /// <summary>
        /// 13.4.查询支付限额协议请求内容
        /// </summary>
        public NTQRYLMTX NTQRYLMTX { get; set; }
    }
    /// <summary>
    /// 13.4.查询支付限额协议请求内容
    /// </summary>
    public class NTQRYLMTX
    {
        /// <summary>
        /// 母公司账号	C(35)
        /// </summary>
        public string FATACC { get; set; }
        /// <summary>
        /// 母公司账号分行号	C(2)	A.1 招行分行
        /// </summary>
        public string FATBBK { get; set; }
        /// <summary>
        /// 子公司账号	C(35)
        /// </summary>
        public string SUBACC { get; set; }
        /// <summary>
        /// 子公司账号分行号	C(2)	A.1 招行分行
        /// </summary>
        public string SUBBBK { get; set; }
    }
}
