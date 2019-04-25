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
    /// 12.7.7.汇出汇款经办查询模式适用资源及控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_7_7 : CMBBase<RQINFO>, IRequest<RS12_7_7>
    {
        /// <summary>
        /// NTQRMCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRMCTL";
        /// <summary>
        /// 12.7.7.汇出汇款经办查询模式适用资源及控制信息请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
