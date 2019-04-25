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
    /// 12.7.8.查询汇入汇款确认业务模式适用资源及控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_7_8 : CMBBase<RQINFO>, IRequest<RS12_7_8>
    {
        /// <summary>
        /// NTIRACTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRACTL";
        /// <summary>
        /// 12.7.8.查询汇入汇款确认业务模式适用资源及控制信息请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
