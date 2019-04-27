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
    /// 25.1.查询网上自助还款业务控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ25_1 : CMBBase<RQINFO>, IRequest<RS25_1>
    {
        /// <summary>
        /// NTQCDCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQCDCTL";
        /// <summary>
        /// 25.1.查询网上自助还款业务控制信息请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
