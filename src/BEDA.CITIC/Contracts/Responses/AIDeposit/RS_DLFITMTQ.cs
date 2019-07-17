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
    /// 通知型智能存款解除关联前查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFITMTQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<NoticeTypeAIDepositReleasing> List { get; set; }
    }
    /// <summary>
    /// 通知型智能存款解除关联前查询
    /// </summary>
    public class NoticeTypeAIDepositReleasing
    {
        /// <summary>
        /// 智能存款账号char(19)
        /// </summary>
        [XmlElement("finAccNo")]
        public string FinAccNo { get; set; }
        /// <summary>
        /// 账户名称varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 通知账号(账户序号) varchar(6)
        /// </summary>
        [XmlElement("notifyAccNo")]
        public string NotifyAccNo { get; set; }
        /// <summary>
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 原始本金decimal(15,2)
        /// </summary>
        [XmlElement("orbl")]
        public decimal Orbl { get; set; }
        /// <summary>
        /// 通知种类char(3) D01：一天通知存款； D07：七天通知存款
        /// </summary>
        [XmlElement("notifyType")]
        public string NotifyType { get; set; }
        /// <summary>
        /// 开户日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime OpenDate { get; set; }
        /// <summary>
        /// 开户日期char(8)，格式YYYYMMDD, 对应<see cref="OpenDate"/>
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
        /// 起息日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RateDate { get; set; }
        /// <summary>
        /// 起息日期char(8)，格式YYYYMMDD, 对应<see cref="RateDate"/>
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
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 备注char(1) 1：智能存款通知存款
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
