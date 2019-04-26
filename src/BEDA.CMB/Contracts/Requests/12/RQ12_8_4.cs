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
    /// 12.8.4.支付机构撤销实时购结汇项下明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_8_4 : CMBBase<RQINFO>, IRequest<RS12_8_4>
    {
        /// <summary>
        /// NTEXCDCL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXCDCL";
        /// <summary>
        /// 12.8.4.支付机构撤销实时购结汇项下明细数据请求内容
        /// </summary>
        public NTEXCDCLX NTEXCDCLX { get; set; }
    }
    /// <summary>
    /// 12.8.4.支付机构撤销实时购结汇项下明细数据请求内容
    /// </summary>
    public class NTEXCDCLX
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 网上业务编号	C(30)
        /// </summary>
        public string APPCNO { get; set; }
    }
}
