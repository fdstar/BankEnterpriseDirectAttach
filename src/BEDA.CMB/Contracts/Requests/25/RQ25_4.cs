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
    /// 25.4.还款利息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ25_4 : CMBBase<RQINFO>, IRequest<RS25_4>
    {
        /// <summary>
        /// NTCDTINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTINT";
        /// <summary>
        /// 25.4.还款利息查询请求内容
        /// </summary>
        public NTCDTINTX1 NTCDTINTX1 { get; set; }
    }
    /// <summary>
    /// 25.4.还款利息查询请求内容
    /// </summary>
    public class NTCDTINTX1
    {
        /// <summary>
        /// 业务编号	C(10)   即“贷款业务号”
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 还款金额	M
        /// </summary>
        public decimal PYOAMT { get; set; }
        /// <summary>
        /// 还款账号	C(35)
        /// </summary>
        public string PYOACC { get; set; }
        /// <summary>
        /// 保留字段 50	C(30)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
