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
    /// 12.7.2.支付机构查询客户号信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_7_2 : CMBBase<RQINFO>, IRequest<RS12_7_2>
    {
        /// <summary>
        /// NTJSHCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJSHCTL";
        /// <summary>
        /// 12.7.2.支付机构查询客户号信息请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
