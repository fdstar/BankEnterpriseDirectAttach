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
    /// 28.1.6.查询大额划拨业务详细信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_1_6 : CMBBase<RQINFO>, IRequest<RS28_1_6>
    {
        /// <summary>
        /// NTGMTIND
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTGMTIND";
        /// <summary>
        /// 28.1.6.查询大额划拨业务详细信息请求内容
        /// </summary>
        public NTGMTINDX1 NTGMTINDX1 { get; set; }
    }
    /// <summary>
    /// 28.1.6.查询大额划拨业务详细信息请求内容
    /// </summary>
    public class NTGMTINDX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
