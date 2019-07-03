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
    /// 通知存款查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLNTYQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<NotifyDeposit> List { get; set; }
    }
    /// <summary>
    /// 通知存款
    /// </summary>
    public class NotifyDeposit
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
        /// 通知账号 char(19)
        /// </summary>
        [XmlElement("notifyAccNo")]
        public string NotifyAccNo { get; set; }
        /// <summary>
        /// 通知类型char(2) 01：一天通知；02：七天通知，由通知存款查询返回
        /// </summary>
        [XmlElement("notifyType")]
        public string NotifyType { get; set; }
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
        /// 卡折存单标志 char(1)，1：卡；2：普通存折；3：存单；4：一本通；5：支票；6：特种存单；7：联通手机
        /// </summary>
        [XmlElement("acFlag")]
        public int AcFlag { get; set; }
        /// <summary>
        /// 存折存单号 char(9)
        /// </summary>
        [XmlElement("bookNo")]
        public string BookNo { get; set; }
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
