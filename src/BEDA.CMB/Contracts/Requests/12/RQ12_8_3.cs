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
    /// 12.8.3.支付机构撤销实时购结汇业务请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_8_3 : CMBBase<RQINFO>, IRequest<RS12_8_3>
    {
        /// <summary>
        /// NTEXCCNL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXCCNL";
        /// <summary>
        /// 12.8.3.支付机构撤销实时购结汇业务请求内容
        /// </summary>
        public NTEXCCNLX1 NTEXCCNLX1 { get; set; }
    }
    /// <summary>
    /// 12.8.3.支付机构撤销实时购结汇业务请求内容
    /// </summary>
    public class NTEXCCNLX1
    {
        /// <summary>
        /// 网上业务编号(母业务的业务参考号)	C(30)   支付机构申请母业务的唯一编号
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(3)	EXS：实时结汇, EXB：实时购汇
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 保留字 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
