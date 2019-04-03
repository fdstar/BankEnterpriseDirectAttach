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
    /// 20.5.联动支付交易明细查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ20_5 : CMBBase<RQINFO>, IRequest<RS20_5>
    {
        /// <summary>
        /// NTLKPINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLKPINF";
        /// <summary>
        /// 20.5.联动支付交易明细查询请求内容
        /// </summary>
        public NTLKPINFX1 NTLKPINFX1 { get; set; }
    }
    /// <summary>
    /// 20.5.联动支付交易明细查询请求内容
    /// </summary>
    public class NTLKPINFX1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
