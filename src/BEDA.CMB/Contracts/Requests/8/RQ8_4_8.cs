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
    /// 8.4.8.产生通知请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_8 : CMBBase<RQINFO>, IRequest<RS8_4_8>
    {
        /// <summary>
        /// NTSMANTF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMANTF";
        /// <summary>
        /// 8.4.8.产生通知请求内容
        /// </summary>
        public NTSMANTFX NTSMANTFX { get; set; }
    }
    /// <summary>
    /// 8.4.8.产生通知请求内容
    /// </summary>
    public class NTSMANTFX
    {
        /// <summary>
        /// 业务类型	C(6)	N08020: 通知存款
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 活期帐号分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 通知存款帐号分行号	C(2)	附录A.1
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 通知存款帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
