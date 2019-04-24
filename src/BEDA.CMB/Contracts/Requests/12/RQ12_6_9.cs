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
    /// 12.6.9.支付机构查询汇款类业务项下子业务明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_9 : CMBBase<RQINFO>, IRequest<RS12_6_9>
    {
        /// <summary>
        /// NTPAYQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYQRT";
        /// <summary>
        /// 12.6.9.支付机构查询汇款类业务项下子业务明细请求内容
        /// </summary>
        public NTPAYQRTX NTPAYQRTX { get; set; }
    }
    /// <summary>
    /// 12.6.9.支付机构查询汇款类业务项下子业务明细请求内容
    /// </summary>
    public class NTPAYQRTX
    {
        /// <summary>
        /// 业务种类	C(3)    	ORT：汇出汇款——外汇清分提供 IRT：汇入汇款——企业银行提供
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 批次号 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 母业务网上业务编号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 轮次序号	N(6)
        /// </summary>
        public int LODSEQ { get; set; }
    }
}
