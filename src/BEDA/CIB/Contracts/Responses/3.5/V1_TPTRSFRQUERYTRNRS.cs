using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.5第三方存管交易查询响应主体 V1.0版本
    /// </summary>
    public class V1_TPTRSFRQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.5.5第三方存管交易查询响应主体
        /// </summary>
        public TPTRSFRQUERYTRNRS TPTRSFRQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.5第三方存管交易查询响应主体
    /// </summary>
    public class TPTRSFRQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.5第三方存管交易查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public TPTRSFRQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.5第三方存管交易查询响应内容
    /// </summary>
    public class TPTRSFRQUERYTRN_RSBODY
        : PAGED_RSBODY<TPTRSFRQUERYTRN_CONTENT>
    {
    }
    /// <summary>
    /// 3.5.5第三方存管交易查询响应明细
    /// </summary>
    public class TPTRSFRQUERYTRN_CONTENT
    {
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD
        /// </summary>
        [XmlElement(Order = 1)]
        public string DTTRN { get; set; }
        /// <summary>
        /// 交易时间 HH:MM:SS
        /// </summary>
        [XmlElement(Order = 2)]
        public string TMTRN { get; set; }
        /// <summary>
        /// 交易时间，如果获取失败则返回null
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(DTTRN + TMTRN, new string[] { "yyyy-MM-dd", "yyyy-MM-ddHH:mm:ss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime time))
                {
                    return time;
                }
                return null;
            }
            set
            {
                this.DTTRN = value?.ToString("yyyy-MM-dd");
                this.TMTRN = value?.ToString("HH:mm:ss");
            }
        }
        /// <summary>
        /// 币种，2位
        /// </summary>
        [XmlElement(Order = 3)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 业务名称，最长20位
        /// </summary>
        [XmlElement(Order = 4)]
        public string BUSNNAME { get; set; }
        /// <summary>
        /// 交易金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 券商名称机构代号，最长8位
        /// </summary>
        [XmlElement(Order = 6)]
        public string BROKER { get; set; }

        /// <summary>
        /// 券商名称，2.0版回
        /// </summary>
        [XmlElement(Order = 16)]
        public string TRUSTEENAME { get; set; }
        /// <summary>
        /// 账户名称，2.0版回
        /// </summary>
        [XmlElement(Order = 17)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 未知  ，2.0版回
        /// </summary>
        [XmlElement(Order = 18)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 未知  ，2.0版回
        /// </summary>
        [XmlElement(Order = 19)]
        public string FUNDACCTNO { get; set; }
    }
}
