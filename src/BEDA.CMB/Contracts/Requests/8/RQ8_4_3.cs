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
    /// 8.4.3.查询定转活可经办帐号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_3 : CMBBase<RQINFO>, IRequest<RS8_4_3>
    {
        /// <summary>
        /// NTFTCQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFTCQRY";
        /// <summary>
        /// 8.4.3.查询定转活可经办帐号请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
