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
    /// 7.1.查询委托贷款业务控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ7_1 : CMBBase<RQINFO>, IRequest<RS7_1>
    {
        /// <summary>
        /// NTQALCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQALCTL";
        /// <summary>
        /// 7.1.查询委托贷款业务控制信息请求内容
        /// 某个业务有哪些可经办的业务模式，可通过查询可经办的业务模式信息（ListMode）获得
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
