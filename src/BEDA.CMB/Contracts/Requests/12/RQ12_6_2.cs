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
    /// 12.6.2.支付机构查询实时购结汇明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_2 : CMBBase<RQINFO>, IRequest<RS12_6_2>
    {
        /// <summary>
        /// NTEXCDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXCDTL";
        /// <summary>
        /// 12.6.2.支付机构查询实时购结汇明细请求内容
        /// </summary>
        public NTEXCINFX1 NTEXCINFX1 { get; set; }
    }
    /// <summary>
    /// 12.6.2.支付机构查询实时购结汇明细请求内容
    /// </summary>
    public class NTEXCINFX1
    {
        /// <summary>
        ///流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
