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
    /// 23.17.口头挂失请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_17 : CMBBase<RQINFO>, IRequest<RS23_17>
    {
        /// <summary>
        /// NTCPRPHO
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRPHO";
        /// <summary>
        /// 23.17.口头挂失请求内容
        /// </summary>
        public NTCPRPHOX NTCPRPHOX { get; set; }
    }
    /// <summary>
    /// 23.17.口头挂失请求内容
    /// </summary>
    public class NTCPRPHOX
    {
        /// <summary>
        /// 模式     	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 公司卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 附件标志 	C(1)
        /// </summary>
        public string ATHFLG { get; set; }
    }
}
