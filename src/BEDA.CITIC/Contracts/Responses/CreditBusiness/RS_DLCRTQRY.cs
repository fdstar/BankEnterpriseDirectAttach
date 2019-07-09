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
    /// 贷款信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCRTQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<LoanInfo> List { get; set; }
    }
    /// <summary>
    /// 贷款信息
    /// </summary>
    public class LoanInfo
    {
        /// <summary>
        /// 贷款账号 char(19)
        /// </summary>
        [XmlElement("creditAccNo")]
        public string CreditAccNo { get; set; }
        /// <summary>
        /// 贷款账户名称 varchar(122)
        /// </summary>
        [XmlElement("creditAccNm")]
        public string CreditAccNm { get; set; }
        /// <summary>
        /// 结算账号 char(19)
        /// </summary>
        [XmlElement("balanceAccNo")]
        public string BalanceAccNo { get; set; }
        /// <summary>
        /// 付息账号 char(19)
        /// </summary>
        [XmlElement("rateAccNo")]
        public string RateAccNo { get; set; }
        /// <summary>
        /// 币种 char(2) ”01”为人民币
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 贷款金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 贷款期限 char(3) 格式举例Y01(一年)、M10（10个月）、D20(20天)
        /// </summary>
        [XmlElement("creditDate")]
        public string CreditDate { get; set; }
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
        /// 额度到期日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 额度到期日 char(8) 格式YYYYMMDD, 对应<see cref="DueDate"/>
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
        /// 利率 decimal(9,7)
        /// </summary>
        [XmlElement("rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// 贷款余额 decimal(15,2)
        /// </summary>
        [XmlElement("balacne")]
        public decimal Balacne { get; set; }
        /// <summary>
        /// 欠息金额 decimal(15,2)
        /// </summary>
        [XmlElement("scoreAmt")]
        public decimal ScoreAmt { get; set; }
        /// <summary>
        /// 逾期金额 decimal(15,2)，(信银国际客户返回)
        /// </summary>
        [XmlElement("overdueAmt")]
        public decimal? OverdueAmt { get; set; }
        /// <summary>
        /// 还款方式 varchar(4)，MSI：SECURED INST LOAN；MUI：UNSECURED INST LOAN；CSFT：CORP SEC FIXED LOAN；CUFT：CORP UNSEC FX LOAN；CUI：CORP UNSEC INST LOAN；CSI：CORP SEC INST LOAN；CSDT：SYNDICATED TERM，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("accType")]
        public string AccType { get; set; }
        /// <summary>
        /// 累计发放金额 decimal(15,2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("totalPutAmt")]
        public decimal? TotalPutAmt { get; set; }
        /// <summary>
        /// 累计还款金额 decimal(15,2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("totalRateAmt")]
        public decimal? TotalRateAmt { get; set; }
        /// <summary>
        /// 下期付款金额 decimal(15,2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("nextPayAmt")]
        public decimal? NextPayAmt { get; set; }
        /// <summary>
        /// 下期付款日期char(8) 格式YYYYMMDD ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlIgnore]
        public DateTime? NextPayDate { get; set; }
        /// <summary>
        /// 下期付款日期char(8) 格式YYYYMMDD, 对应<see cref="NextPayDate"/>
        /// </summary>
        [XmlElement("nextPayDate")]
        public string NextPayDateStr
        {
            get
            {
                return this.NextPayDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.NextPayDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NextPayDate = tmp;
                }
            }
        }
    }
}
