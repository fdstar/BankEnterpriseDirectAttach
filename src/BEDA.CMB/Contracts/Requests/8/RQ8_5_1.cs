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
    /// 8.5.1.查询可经办活期转智能定期账号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_5_1 : CMBBase<RQINFO>, IRequest<RS8_5_1>
    {
        /// <summary>
        /// NTCTAACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCTAACC";
        /// <summary>
        /// 8.5.1.查询可经办活期转智能定期账号请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
