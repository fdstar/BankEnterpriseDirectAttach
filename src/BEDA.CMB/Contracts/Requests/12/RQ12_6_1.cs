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
    /// 12.6.1.支付机构查询结售汇申请明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_1 : CMBBase<RQINFO>, IRequest<RS12_6_1>
    {
        /// <summary>
        /// NTJSHDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSHDTL";
        /// <summary>
        /// 12.6.1.支付机构查询结售汇申请明细请求内容
        /// </summary>
        public NTJSHDTLX NTJSHDTLX { get; set; }
    }
    /// <summary>
    /// 12.6.1.支付机构查询结售汇申请明细请求内容
    /// </summary>
    public class NTJSHDTLX
    {
        /// <summary>
        ///流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
