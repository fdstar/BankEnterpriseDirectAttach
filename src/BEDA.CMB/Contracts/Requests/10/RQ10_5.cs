using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 10.5.子公司现金池当天交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_5 : CMBBase<RQINFO>, IRequest<RS10_5>
    {
        /// <summary>
        /// SDKNTCASTDT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCASTDT";
        /// <summary>
        /// 10.5.子公司现金池当天交易查询请求内容
        /// </summary>
        public NTTRXSTRY NTTRXSTRY { get; set; }
    }
}
