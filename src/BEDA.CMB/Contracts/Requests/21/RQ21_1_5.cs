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
    /// 21.1.5.业务总揽查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_1_5 : CMBBase<RQINFO>, IRequest<RS21_1_5>
    {
        /// <summary>
        /// NTQNPEBP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQNPEBP";
        /// <summary>
        /// 21.1.5.业务总揽查询请求内容
        /// </summary>
        public NTQNPEBPY NTQNPEBPY { get; set; }
    }
    /// <summary>
    /// 21.1.5.业务总揽查询请求内容
    /// </summary>
    public class NTQNPEBPY
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string QRYACC { get; set; }
        /// <summary>
        /// 交易方向	C(1)	I：提回 O：提出
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 业务种类	C(3)	101：网银贷记 103：网银借记 105：第三方贷记
        /// </summary>
        public string MSGNBR { get; set; }
        /// <summary>
        /// 交易起始日期	D   日期间隔不能超过一个月
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 交易起始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易结束日期	D   日期间隔不能超过一个月
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 交易结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 最小金额	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最大金额	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 交易状态	C(2)	附录 A.48
        /// </summary>
        public string TRXSTS { get; set; }
        /// <summary>
        /// 付款人账号	C(35)
        /// </summary>
        public string PYREAC { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string PYEEAC { get; set; }
        /// <summary>
        /// 内部协议号	C(10)
        /// </summary>
        public string CNVNBR { get; set; }
    }
}
