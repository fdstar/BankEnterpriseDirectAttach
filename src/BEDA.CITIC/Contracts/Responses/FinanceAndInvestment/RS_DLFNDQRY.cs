using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 定期存款查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFNDQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<FixedDeposit> List { get; set; }
    }
    /// <summary>
    /// 定期存款
    /// </summary>
    public class FixedDeposit
    {
        /// <summary>
        /// 活期账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 活期账户名称 varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 定期账号 char(19)
        /// </summary>
        [XmlElement("fixAccNo")]
        public string FixAccNo { get; set; }
        /// <summary>
        /// 存期 char(3)，M03：三个月；M06：六个月；Y01：一年；当查询账号为信银国际账号时，该值为天数
        /// </summary>
        [XmlElement("perd")]
        public string Perd { get; set; }
        /// <summary>
        /// 起息日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RateDate { get; set; }
        /// <summary>
        /// 起息日期 char(8) 格式YYYYMMDD, 对应<see cref="RateDate"/>
        /// </summary>
        [XmlElement("rateDate")]
        public string RateDateStr
        {
            get
            {
                return this.RateDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RateDate = tmp;
                }
            }
        }
        /// <summary>
        /// 原始本金 decimal(15，2)
        /// </summary>
        [XmlElement("orbl")]
        public decimal Orbl { get; set; }
        /// <summary>
        /// 账户余额 decimal(15，2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 利率 decimal(9，7) ，返回值为百分数，例如返回3.05即，利率为3.05%
        /// </summary>
        [XmlElement("rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// 结转方式 char(1)  0：凭存折；1：凭密码；2：凭证件；3：凭印鉴；4：变码印鉴；5：批量扣帐；6：自动结转；7：不自动结转；8：凭存单；当查询账号为信银国际账号时，字典项为：P：Renew with Principal only. Interest transfers to current account；I：Renew with Principal and interest；A：Not renew. Principal and interest transfer to current account；O：Not renew. Principal and interest remain at time deposit account. Allowed manual renew；
        /// </summary>
        [XmlElement("wdtp")]
        public string Wdtp { get; set; }
        /// <summary>
        /// 开户日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime OpenDate { get; set; }
        /// <summary>
        /// 开户日期 char(8) 格式YYYYMMDD, 对应<see cref="OpenDate"/>
        /// </summary>
        [XmlElement("openDate")]
        public string OpenDateStr
        {
            get
            {
                return this.OpenDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OpenDate = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 到期日 char(8) 格式YYYYMMDD, 对应<see cref="DueDate"/>
        /// </summary>
        [XmlElement("dueDate")]
        public string DueDateStr
        {
            get
            {
                return this.DueDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 定期存款币种char(2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
    }
}
