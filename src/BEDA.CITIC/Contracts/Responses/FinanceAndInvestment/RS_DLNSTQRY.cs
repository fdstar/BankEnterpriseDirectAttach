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
    /// 通知取消经办前查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLNSTQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<NotifyDepositCancel> List { get; set; }
    }
    /// <summary>
    /// 通知取消经办
    /// </summary>
    public class NotifyDepositCancel
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
        /// 币种 char(2)，”01”为人民币
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 通知账号 char(19)
        /// </summary>
        [XmlElement("notifyAccNo")]
        public string NotifyAccNo { get; set; }
        /// <summary>
        /// 通知类型 char(2) 01：一天通知；02：七天通知
        /// </summary>
        [XmlElement("notifyType")]
        public string NotifyType { get; set; }
        /// <summary>
        /// 通知编号 char(10)
        /// </summary>
        [XmlElement("notifyId")]
        public string NotifyId { get; set; }
        /// <summary>
        /// 通知日期 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime NotifyDate { get; set; }
        /// <summary>
        /// 通知日期 char(8)格式YYYYMMDD, 对应<see cref="NotifyDate"/>
        /// </summary>
        [XmlElement("notifyDate")]
        public string NotifyDateStr
        {
            get
            {
                return this.NotifyDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NotifyDate = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额 decimal(15，2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 账户余额 decimal(15，2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 支取日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime WithDrawDate { get; set; }
        /// <summary>
        /// 支取日期char(8) 格式YYYYMMDD, 对应<see cref="WithDrawDate"/>
        /// </summary>
        [XmlElement("withDrawDate")]
        public string WithDrawDateStr
        {
            get
            {
                return this.WithDrawDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.WithDrawDate = tmp;
                }
            }
        }
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

    }
}
