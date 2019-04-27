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
    /// 25.3.还款业务经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ25_3 : CMBBase<RQINFO>, IRequest<RS25_3>
    {
        /// <summary>
        /// NTCDTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTOPR";
        /// <summary>
        /// 25.3.还款业务经办请求内容
        /// </summary>
        public NTCDTOPRX1 NTCDTOPRX1 { get; set; }
    }
    /// <summary>
    /// 25.3.还款业务经办请求内容
    /// </summary>
    public class NTCDTOPRX1
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2) 	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 贷款业务号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 还款日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PYODAT { get; set; }
        /// <summary>
        /// 还款日	D, 对应<see cref="PYODAT"/>
        /// </summary>
        [XmlElement("PYODAT")]
        public string PYODATStr
        {
            get
            {
                return this.PYODAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PYODAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PYODAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 还款金额	M
        /// </summary>
        public decimal LONAMT { get; set; }
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
