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
    /// 23.4.取公司卡当天交易请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_4 : CMBBase<RQINFO>, IRequest<RS23_4>
    {
        /// <summary>
        /// NTCPRTRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRTRT";
        /// <summary>
        /// 23.4.取公司卡当天交易请求内容
        /// </summary>
        public NTCPRTRTY NTCPRTRTY { get; set; }
    }
    /// <summary>
    /// 23.4.取公司卡当天交易请求内容
    /// </summary>
    public class NTCPRTRTY
    {
        /// <summary>
        /// 公司卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 交易金额下限 	M
        /// </summary>
        public decimal? LOWAMT { get; set; }
        /// <summary>
        /// 交易金额上限 	M
        /// </summary>
        public decimal? HGHAMT { get; set; }
        /// <summary>
        /// 续传     	C(40)
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
