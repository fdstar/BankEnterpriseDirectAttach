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
    /// 12.7.9.查询支付机构外汇集中收付业务模式适用资源及控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_7_9 : CMBBase<RQINFO>, IRequest<RS12_7_9>
    {
        /// <summary>
        /// NTJZPCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTJZPCTL";
        /// <summary>
        /// 12.7.9.查询支付机构外汇集中收付业务模式适用资源及控制信息请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
