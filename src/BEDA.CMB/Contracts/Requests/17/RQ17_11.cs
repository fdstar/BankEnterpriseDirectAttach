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
    /// 17.11.查询虚拟户历史月积数请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_11 : CMBBase<RQINFO>, IRequest<RS17_11>
    {
        /// <summary>
        /// NTMTHAUB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTHAUB";
        /// <summary>
        /// 17.11.查询虚拟户历史月积数请求内容
        /// </summary>
        public NTMTHAUBX NTMTHAUBX { get; set; }
    }
    /// <summary>
    /// 17.11.查询虚拟户历史月积数请求内容
    /// </summary>
    public class NTMTHAUBX
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   填空表示查询该账号下所有虚拟户信息（不能为默认虚拟户编号）
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 起始年月	C(6)	格式： YYYYMM
        /// </summary>
        public string BEGMTH { get; set; }
        /// <summary>
        /// 结束年月	C(6)	格式：YYYYMM   本年或上一年，小于当月，不小于起始年月
        /// </summary>
        public string ENDMTH { get; set; }
    }
}
