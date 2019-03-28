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
    /// 7.8.委贷还款经办请求请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ7_8 : CMBBase<RQINFO>, IRequest<RS7_8>
    {
        /// <summary>
        /// NTOPRAPO
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRAPO";
        /// <summary>
        /// 7.8.委贷还款经办请求请求内容
        /// </summary>
        public NTOPRAPOX NTOPRAPOX { get; set; }
    }
    /// <summary>
    /// 7.8.委贷还款经办请求请求内容
    /// </summary>
    public class NTOPRAPOX
    {
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2,2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 贷款业务号	C(10)   通过7.7查询待还款委托贷款业务取得
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 还款日	D
        /// </summary>
        [XmlIgnore]
        public DateTime PYODAT { get; set; }
        /// <summary>
        /// 还款日	D, 对应<see cref="PYODAT"/>
        /// </summary>
        [XmlElement("PYODAT")]
        public string PYODATStr
        {
            get
            {
                return this.PYODAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PYODAT = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(2,2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 放款金额	M   支持提前部分还款
        /// </summary>
        public decimal LONAMT { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
