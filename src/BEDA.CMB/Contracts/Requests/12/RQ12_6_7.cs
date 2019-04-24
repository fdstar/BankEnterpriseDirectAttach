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
    /// 12.6.7.支付机构查询实时购结汇项下子业务明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_7 : CMBBase<RQINFO>, IRequest<RS12_6_7>
    {
        /// <summary>
        /// NTEXDQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXDQRT";
        /// <summary>
        /// 12.6.7.支付机构查询实时购结汇项下子业务明细请求内容
        /// </summary>
        public NTJSBQRTX NTJSBQRTX { get; set; }
    }
}
