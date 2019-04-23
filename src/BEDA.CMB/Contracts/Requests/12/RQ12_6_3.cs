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
    /// 12.6.3.支付机构查询汇出汇款申请明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_3 : CMBBase<RQINFO>, IRequest<RS12_6_3>
    {
        /// <summary>
        /// SDKNTRTAINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTRTAINF";
        /// <summary>
        /// 12.6.3.支付机构查询汇出汇款申请明细请求内容
        /// </summary>
        public NTRTAINFX1 NTRTAINFX1 { get; set; }
    }
    /// <summary>
    /// 12.6.3.支付机构查询汇出汇款申请明细请求内容
    /// </summary>
    public class NTRTAINFX1
    {
        /// <summary>
        ///流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 新版本标志	C(1)   固定填A
        /// </summary>
        public string UBKTYP { get; set; } = "A";
    }
}
