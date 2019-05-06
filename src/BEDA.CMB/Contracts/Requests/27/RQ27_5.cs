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
    /// 27.5.划拨关系明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_5 : CMBBase<RQINFO>, IRequest<RS27_5>
    {
        /// <summary>
        /// NTMTLQR3
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLQR3";
        /// <summary>
        /// 27.5.划拨关系明细查询请求内容
        /// </summary>
        public NTMTLQR3X1 NTMTLQR3X1 { get; set; }
    }
    /// <summary>
    /// 27.5.划拨关系明细查询请求内容
    /// </summary>
    public class NTMTLQR3X1
    {
        /// <summary>
        /// 产品编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 划拨关系编号	C(5)
        /// </summary>
        public string RLTNBR { get; set; }
    }
}
