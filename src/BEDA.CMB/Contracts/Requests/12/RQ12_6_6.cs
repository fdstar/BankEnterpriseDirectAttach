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
    /// 12.6.6.支付机构查询实时购结汇项下子业务上传批次列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_6_6 : CMBBase<RQINFO>, IRequest<RS12_6_6>
    {
        /// <summary>
        /// NTEXCBLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXCBLT";
        /// <summary>
        /// 12.6.6.支付机构查询实时购结汇项下子业务上传批次列表请求内容
        /// </summary>
        public NTJSHBLTY NTJSHBLTY { get; set; }
    }
}
