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
    /// 23.18.取公司结算户当天交易请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_18 : CMBBase<RQINFO>, IRequest<RS23_18>
    {
        /// <summary>
        /// NTCPATRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPATRT";
        /// <summary>
        /// 23.18.取公司结算户当天交易请求内容
        /// </summary>
        public NTCPATRTY NTCPATRTY { get; set; }
    }
    /// <summary>
    /// 23.18.取公司结算户当天交易请求内容
    /// </summary>
    public class NTCPATRTY
    {
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 交易金额 	M
        /// </summary>
        public decimal? LOWAMT { get; set; }
        /// <summary>
        /// 交易金额 	M
        /// </summary>
        public decimal? HGHAMT { get; set; }
    }
}
