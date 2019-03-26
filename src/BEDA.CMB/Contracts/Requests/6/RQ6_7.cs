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
    /// 6.7.商务支付现金退款查询信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_7 : CMBBase<RQINFO>, IRequest<RS6_7>
    {
        /// <summary>
        /// NTQRYDBK
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYDBK";
        /// <summary>
        /// 6.7.商务支付现金退款查询信息请求内容
        /// </summary>
        public NTQRYDBKY NTQRYDBKY { get; set; }
    }
    /// <summary>
    /// 6.7.商务支付现金退款查询信息请求内容
    /// </summary>
    public class NTQRYDBKY
    {
        /// <summary>
        /// 查询类型 	C(1)	A 使用银行订单信息查询 B 使用对方商户订单信息查询
        /// </summary>
        public string INQTYP { get; set; }
        /// <summary>
        /// 商户编号 	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 订单号   	C(40)
        /// </summary>
        public string BEGSEQ { get; set; }
        /// <summary>
        /// 订单支付号	C(10)   原定单支付号为空时可以不填
        /// </summary>
        public string BEGSUB { get; set; }
        /// <summary>
        /// 订单号   	C(40)
        /// </summary>
        public string ENDSEQ { get; set; }
        /// <summary>
        /// 订单支付号	C(10)   原定单支付号为空时可以不填
        /// </summary>
        public string ENDSUB { get; set; }
    }
}
