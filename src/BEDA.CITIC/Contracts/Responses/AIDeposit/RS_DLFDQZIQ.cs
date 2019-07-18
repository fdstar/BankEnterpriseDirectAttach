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
    /// 组合型智能存款利息凭证信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFDQZIQ : RsBase
    {
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称char(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MixedTypeAIDepositInterestVoucher> List { get; set; }
    }
    /// <summary>
    /// 组合型智能存款利息凭证信息
    /// </summary>
    public class MixedTypeAIDepositInterestVoucher
    {
        /// <summary>
        /// 收息账号char(19)
        /// </summary>
        [XmlElement("rcvAccNo")]
        public string RcvAccNo { get; set; }
        /// <summary>
        /// 收息日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RcvDate { get; set; }
        /// <summary>
        /// 收息日期char(8)，格式YYYYMMDD, 对应<see cref="RcvDate"/>
        /// </summary>
        [XmlElement("rcvDate")]
        public string RcvDateStr
        {
            get
            {
                return this.RcvDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RcvDate = tmp;
                }
            }
        }
        /// <summary>
        /// 计息日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime AccrualDate { get; set; }
        /// <summary>
        /// 计息日期char(8)，格式YYYYMMDD, 对应<see cref="AccrualDate"/>
        /// </summary>
        [XmlElement("accrualDate")]
        public string AccrualDateStr
        {
            get
            {
                return this.AccrualDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.AccrualDate = tmp;
                }
            }
        }
        /// <summary>
        /// 付息日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RepayDate { get; set; }
        /// <summary>
        /// 付息日期char(8)，格式YYYYMMDD, 对应<see cref="RepayDate"/>
        /// </summary>
        [XmlElement("repayDate")]
        public string RepayDateStr
        {
            get
            {
                return this.RepayDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RepayDate = tmp;
                }
            }
        }
        /// <summary>
        /// 定期利息decimal(15,2)
        /// </summary>
        [XmlElement("fixInrt")]
        public decimal FixInrt { get; set; }
        /// <summary>
        /// 活期利息decimal(15,2)
        /// </summary>
        [XmlElement("curInrt")]
        public decimal CurInrt { get; set; }
        /// <summary>
        /// 利息金额decimal(15,2)
        /// </summary>
        [XmlElement("inrtAmt")]
        public decimal InrtAmt { get; set; }
        /// <summary>
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
 
    }
}
