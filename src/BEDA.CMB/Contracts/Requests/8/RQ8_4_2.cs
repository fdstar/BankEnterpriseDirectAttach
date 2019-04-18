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
    /// 8.4.2.活期转定期经办请求请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_2 : CMBBase<RQINFO>, IRequest<RS8_4_2>
    {
        /// <summary>
        /// NTCTFOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCTFOPR";
        /// <summary>
        /// 8.4.2.活期转定期经办请求请求内容
        /// </summary>
        public NTCTFOPRX NTCTFOPRX { get; set; }
    }
    /// <summary>
    /// 8.4.2.活期转定期经办请求请求内容
    /// </summary>
    public class NTCTFOPRX
    {
        /// <summary>
        /// 业务类型	C(6)	N08010: 定活互转
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 存期	N(3,0)	附录A.8存期代码   活期帐号为在岸帐号时必填
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 离岸存期	N(6,0)	A.9离岸存期代码或A.10同业存期代码    活期帐号为离岸帐号或同业帐号时必填
        /// </summary>
        public string TERDUR { get; set; }
        /// <summary>
        /// 自动转存标志	C(1)	1：不转存；2：本息转存；3：本金转存，利息转活期   活期帐号为离岸帐号时必填
        /// </summary>
        public string ATOFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
