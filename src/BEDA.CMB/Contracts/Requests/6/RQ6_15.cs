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
    /// 6.15.平台查询票据明细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ6_15 : CMBBase<RQINFO>, IRequest<RS6_15>
    {
        /// <summary>
        /// NTECDPLF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECDPLF";
        /// <summary>
        /// 6.15.平台查询票据明细信息请求内容
        /// </summary>
        public NTECDPLFY1 NTECDPLFY1 { get; set; }
    }
    /// <summary>
    /// 6.15.平台查询票据明细信息请求内容
    /// </summary>
    public class NTECDPLFY1
    {
        /// <summary>
        /// 订单号    	C(10)   银行订单号，从承兑通知里获取
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 订单支付号	C(10)   银行订单支付号，从承兑通知里获取
        /// </summary>
        public string SUBSEQ { get; set; }
        /// <summary>
        /// 商户编号	C(10)
        /// </summary>
        public string MCHNBR { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
