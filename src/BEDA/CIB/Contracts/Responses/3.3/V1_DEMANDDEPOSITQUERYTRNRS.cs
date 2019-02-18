using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.3.4非定期存款信息查询响应主体
    /// </summary>
    public class V1_DEMANDDEPOSITQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.3.4非定期存款信息查询
        /// </summary>
        public DEMANDDEPOSITQUERYTRNRS DEMANDDEPOSITQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.3.4非定期存款信息查询
    /// </summary>
    public class DEMANDDEPOSITQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.3.4非定期存款账户信息，必回
        /// </summary>
        [XmlElement(Order = 2)]
        public DEMANDDEPOSITQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.3.4非定期存款信息查询结果
    /// </summary>
    public class DEMANDDEPOSITQUERYTRN_RSBODY
    {
        /// <summary>
        /// 开户行，长度60位，非必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 账号，长度18位，必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位，必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 存款金额，2位小数，必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 协定执行利率，非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? CONSULT_INTRST { get; set; }
        /// <summary>
        /// 活期执行利率，非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? DEMAND_INTRST { get; set; }
        /// <summary>
        /// 起息日期，格式yyyyMMdd
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起息日期，格式yyyyMMdd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 6)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
    }
}
