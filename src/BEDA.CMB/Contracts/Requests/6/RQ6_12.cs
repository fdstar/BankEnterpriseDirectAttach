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
    /// 6.12.电票出票担保支付平台确认请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_12 : CMBBase<RQINFO>, IRequest<RS6_12>
    {
        /// <summary>
        /// NTPLFNTF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPLFNTF";
        /// <summary>
        /// 6.12.电票出票担保支付平台确认请求内容
        /// </summary>
        public NTPLFNTFX1 NTPLFNTFX1 { get; set; }
    }
    /// <summary>
    /// 6.12.电票出票担保支付平台确认请求内容
    /// </summary>
    public class NTPLFNTFX1
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
        /// 人行票号	C(30)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 平台确认标志	C(1)	P：放票，允许卖家发起签收 R: 撤票，允许买家发起撤销提示收票及撤票
        /// </summary>
        public string PLFNTF { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
