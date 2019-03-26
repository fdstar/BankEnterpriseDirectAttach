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
    /// 6.14.平台撤销订单请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_14 : CMBBase<RQINFO>, IRequest<RS6_14>
    {
        /// <summary>
        /// NTPLFCNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPLFCNL";
        /// <summary>
        /// 6.14.平台撤销订单请求内容
        /// </summary>
        public NTPLFCNLX1 NTPLFCNLX1 { get; set; }
    }
    /// <summary>
    /// 6.14.平台撤销订单请求内容
    /// </summary>
    public class NTPLFCNLX1
    {
        /// <summary>
        /// 商户编号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 对方商户号   	C(10)
        /// </summary>
        public string REFMCH { get; set; }
        /// <summary>
        /// 对方订单号   	C(40)
        /// </summary>
        public string REFORD { get; set; }
        /// <summary>
        /// 对方订单支付号	C(10)
        /// </summary>
        public string SUBORD { get; set; }
        /// <summary>
        /// 付方付款账号	C(30)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
