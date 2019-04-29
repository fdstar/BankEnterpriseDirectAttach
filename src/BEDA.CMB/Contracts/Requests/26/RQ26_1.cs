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
    /// 26.1.取模式信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_1 : CMBBase<RQINFO>, IRequest<RS26_1>
    {
        /// <summary>
        /// NTECKCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKCTL";
        /// <summary>
        /// 26.1.取模式信息请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
