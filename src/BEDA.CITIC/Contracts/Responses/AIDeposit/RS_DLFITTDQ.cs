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
    /// 通知型智能存款明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFITTDQ : RsBase
    {
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("frzAmt")]
        public decimal FrzAmt { get; set; }
        /// <summary>
        /// 可用余额decimal(15,2)
        /// </summary>
        [XmlElement("avlAmt")]
        public decimal AvlAmt { get; set; }
        /// <summary>
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<NoticeTypeAIDepositDetail> List { get; set; }
    }
    /// <summary>
    /// 通知型智能存款明细
    /// </summary>
    public class NoticeTypeAIDepositDetail
    {
        /// <summary>
        /// 通知账号(账户序号) varchar(6)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 产品种类2：通知 char(1)
        /// </summary>
        [XmlElement("prdType")]
        public string PrdType { get; set; }
        /// <summary>
        /// 储种 char(3) D01：1天通知；D07：7天通知
        /// </summary>
        [XmlElement("dept")]
        public string Dept { get; set; }
        /// <summary>
        /// 开户金额decimal(15,2)
        /// </summary>
        [XmlElement("openAmt")]
        public decimal OpenAmt { get; set; }
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
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 到期日char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime OverDate { get; set; }
        /// <summary>
        /// 到期日char(8)，格式YYYYMMDD, 对应<see cref="OverDate"/>
        /// </summary>
        [XmlElement("overDate")]
        public string OverDateStr
        {
            get
            {
                return this.OverDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OverDate = tmp;
                }
            }
        }
        /// <summary>
        /// 利率decimal(9,7)
        /// </summary>
        [XmlElement("rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// 支取金额decimal(15,2)
        /// </summary>
        [XmlElement("drawAmt")]
        public decimal DrawAmt { get; set; }
        /// <summary>
        /// 实收利息decimal(15,2)
        /// </summary>
        [XmlElement("rcvInrt")]
        public decimal RcvInrt { get; set; }
        /// <summary>
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 状态 char(1) 1：正常；2：销户；3：解除
        /// </summary>
        [XmlElement("connStt")]
        public int ConnStt { get; set; }
        /// <summary>
        /// 关联日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime ConnDate { get; set; }
        /// <summary>
        /// 关联日期char(8)，格式YYYYMMDD, 对应<see cref="ConnDate"/>
        /// </summary>
        [XmlElement("connDate")]
        public string ConnDateStr
        {
            get
            {
                return this.ConnDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ConnDate = tmp;
                }
            }
        }
        /// <summary>
        /// 解除日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RmvDate { get; set; }
        /// <summary>
        /// 解除日期char(8)，格式YYYYMMDD, 对应<see cref="RmvDate"/>
        /// </summary>
        [XmlElement("rmvDate")]
        public string RmvDateStr
        {
            get
            {
                return this.RmvDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RmvDate = tmp;
                }
            }
        }
        /// <summary>
        /// 销户日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime CclDate { get; set; }
        /// <summary>
        /// 销户日期char(8)，格式YYYYMMDD, 对应<see cref="CclDate"/>
        /// </summary>
        [XmlElement("cclDate")]
        public string CclDateStr
        {
            get
            {
                return this.CclDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CclDate = tmp;
                }
            }
        }
    }
}
