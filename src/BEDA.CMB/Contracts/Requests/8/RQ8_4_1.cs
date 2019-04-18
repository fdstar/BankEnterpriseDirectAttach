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
    /// 8.4.1.查询用户有权经办活期账号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_1 : CMBBase<RQINFO>, IRequest<RS8_4_1>
    {
        /// <summary>
        /// NTCTFQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCTFQRY";
        /// <summary>
        /// 8.4.1.查询用户有权经办活期账号请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
