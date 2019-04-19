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
    /// 8.5.9.查询可申请转网下智能定期账号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_5_9 : CMBBase<RQINFO>, IRequest<RS8_5_9>
    {
        /// <summary>
        /// NTTCAAPC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCAAPC";
        /// <summary>
        /// 8.5.9.查询可申请转网下智能定期账号请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
