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
    /// 22.1.4.贴现申请清单综合查询明细请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_1_4 : CMBBase<RQINFO>, IRequest<RS22_1_4>
    {
        /// <summary>
        /// NTBSCDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBSCDTL";
        /// <summary>
        /// 22.1.4.贴现申请清单综合查询明细请求内容
        /// </summary>
        public NTBSCDTLX1 NTBSCDTLX1 { get; set; }
    }
    /// <summary>
    /// 22.1.4.贴现申请清单综合查询明细请求内容
    /// </summary>
    public class NTBSCDTLX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
