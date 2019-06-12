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
    /// 余额查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBALQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AccountBalance> List { get; set; }
    }
    /// <summary>
    /// 账户余额信息
    /// </summary>
    public class AccountBalance
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
        /// 币种 char(2)
        /// </summary>
        [XmlElement("currencyID")]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 开户行名称 varchar(122)
        /// </summary>
        [XmlElement("openBankName")]
        public string OpenBankName { get; set; }
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
        /// 可用账户余额 decimal(15,2)
        /// </summary>
        [XmlElement("usableBalance")]
        public decimal UsableBalance { get; set; }
        /// <summary>
        /// 账号余额--decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 冻结（或看管）金额decimal(15,2)
        /// </summary>
        [XmlElement("forzenAmt")]
        public decimal ForzenAmt { get; set; }
        /// <summary>
        /// 账号状态char(1)， A：正常；D:睡眠；F:冻结，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("frozenFlag")]
        public string FrozenFlag { get; set; }
        /// <summary>
        /// 账户类型 char(2)，ST:活期储蓄；IM:活期支票，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("accountType")]
        public string AccountType { get; set; }
        /// <summary>
        /// 法透额度decimal(15,2)，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("lawptLmt")]
        public decimal? LawptLmt { get; set; }
    }
}
