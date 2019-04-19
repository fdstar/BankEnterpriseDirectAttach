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
    /// 8.6.5.组合存款业务申请明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_6_5 : CMBBase<RQINFO>, IRequest<RS8_6_5>
    {
        /// <summary>
        /// NTCMAINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAINQ";
        /// <summary>
        /// 8.6.5.组合存款业务申请明细查询请求内容
        /// </summary>
        public NTCMAINQX1 NTCMAINQX1 { get; set; }
    }
    /// <summary>
    /// 8.6.5.组合存款业务申请明细查询请求内容
    /// </summary>
    public class NTCMAINQX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
