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
    /// 8.11.1.银期转账经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_11_1 : CMBBase<RQINFO>, IRequest<RS8_11_1>
    {
        /// <summary>
        /// NTBTFOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFOPR";
        /// <summary>
        /// 8.11.1.银期转账经办请求内容
        /// </summary>
        public NTSECOPRX NTSECOPRX { get; set; }
        /// <summary>
        /// 8.11.1.银期转账经办请求内容
        /// </summary>
        public NTBTFOPRX1 NTBTFOPRX1 { get; set; }
    }
    /// <summary>
    /// 8.11.1.银期转账经办请求内容
    /// </summary>
    public class NTBTFOPRX1
    {
        /// <summary>
        /// 期货公司编号	C6)
        /// </summary>
        public string FUTNBR { get; set; }
        /// <summary>
        /// 保证金账号	C30)
        /// </summary>
        public string MARACT { get; set; }
    }
}
