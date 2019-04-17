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
    /// 8.2.1.基金定投协议模式适用帐号列表查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_1 : CMBBase<RQINFO>, IRequest<RS8_2_1>
    {
        /// <summary>
        /// NTFIXCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFIXCTL";
        /// <summary>
        /// 8.2.1.基金定投协议模式适用帐号列表查询请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
