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
    /// 12.8.1.支付机构撤销结售汇申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_8_1 : CMBBase<RQINFO>, IRequest<RS12_8_1>
    {
        /// <summary>
        /// NTJSHCNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSHCNL";
        /// <summary>
        /// 12.8.1.支付机构撤销结售汇申请请求内容
        /// </summary>
        public NTJSHCNLX1 NTJSHCNLX1 { get; set; }
    }
    /// <summary>
    /// 12.8.1.支付机构撤销结售汇申请请求内容
    /// </summary>
    public class NTJSHCNLX1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号       	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 网上业务编号(母业务的业务参考号)	C(30)   支付机构申请母业务的唯一编号
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(3)	BEX：结汇申请 VEN：购汇申请
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 保留字 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
