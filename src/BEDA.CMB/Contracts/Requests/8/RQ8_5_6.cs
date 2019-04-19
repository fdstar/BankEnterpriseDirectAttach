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
    /// 8.5.6.智能定期业务申请明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_5_6 : CMBBase<RQINFO>, IRequest<RS8_5_6>
    {
        /// <summary>
        /// NTTCADTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTTCADTL";
        /// <summary>
        /// 8.5.6.智能定期业务申请明细查询请求内容
        /// </summary>
        public NTTCADTLX1 NTTCADTLX1 { get; set; }
    }
    /// <summary>
    /// 8.5.6.智能定期业务申请明细查询请求内容
    /// </summary>
    public class NTTCADTLX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
