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
    /// 账户信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLACCQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AccountInfo> List { get; set; }
    }
    /// <summary>
    /// 账户信息
    /// </summary>
    public class AccountInfo
    {
        /// <summary>
        /// 账户状态 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 账户状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称 varchar(122)
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 开户行名称 varchar(122)
        /// </summary>
        [XmlElement("openBankName")]
        public string OpenBankName { get; set; }
        /// <summary>
        /// 开户日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime OpenDate { get; set; }
        /// <summary>
        /// 开户日期 char(8), 对应<see cref="OpenDate"/>
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
        /// 账户种类 char(1)
        /// </summary>
        [XmlElement("accountType")]
        public string AccountType { get; set; }
        /// <summary>
        /// 协定金额deciamal(15,2)
        /// </summary>
        [XmlElement("strikeAmount")]
        public decimal StrikeAmount { get; set; }
        /// <summary>
        /// 协定存款利率deciamal(9,7)
        /// </summary>
        [XmlElement("strikeRate")]
        public decimal StrikeRate { get; set; }
        /// <summary>
        /// 优惠利率deciamal(9,7)
        /// </summary>
        [XmlElement("preferentialRate")]
        public decimal PreferentialRate { get; set; }
        /// <summary>
        /// 基本利息收入账号char(19)
        /// </summary>
        [XmlElement("interestAccountNo")]
        public string InterestAccountNo { get; set; }
        /// <summary>
        /// 最近交易日 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime LastTranDate { get; set; }
        /// <summary>
        /// 最近交易日 char(8), 对应<see cref="LastTranDate"/>
        /// </summary>
        [XmlElement("lastTranDate")]
        public string LastTranDateStr
        {
            get
            {
                return this.LastTranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LastTranDate = tmp;
                }
            }
        }
        /// <summary>
        /// 上日余额 decimal(15,2)
        /// </summary>
        [XmlElement("lastBalance")]
        public decimal LastBalance { get; set; }
        /// <summary>
        /// 冻结金额 decimal(15,2)
        /// </summary>
        [XmlElement("freezeAmount")]
        public decimal FreezeAmount { get; set; }
        /// <summary>
        /// 看管金额 decimal(15,2)
        /// </summary>
        [XmlElement("custodyAmount")]
        public decimal CustodyAmount { get; set; }
        /// <summary>
        /// 账号余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
    }
}
