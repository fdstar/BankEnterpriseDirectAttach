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
    /// 8.5.3.查询可经办智能定期转活期账号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_5_3 : CMBBase<RQINFO>, IRequest<RS8_5_3>
    {
        /// <summary>
        /// NTATCACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTATCACC";
        /// <summary>
        /// 8.5.3.查询可经办智能定期转活期账号请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
