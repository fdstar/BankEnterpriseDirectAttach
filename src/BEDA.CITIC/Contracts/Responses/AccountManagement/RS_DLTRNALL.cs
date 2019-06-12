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
    /// 账户明细信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLTRNALL : RsBase
    {
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
        /// 总记录条数 int
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }
        /// <summary>
        /// 返回记录条数 int
        /// </summary>
        [XmlElement("returnRecords")]
        public int ReturnRecords { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AccountTransaction> List { get; set; }
    }
    /// <summary>
    /// 账户交易明细信息
    /// </summary>
    public class AccountTransaction
    {
        /// <summary>
        /// 交易日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDate { get; set; }
        /// <summary>
        /// 交易时间 char(6) 格式hhmmss
        /// </summary>
        [XmlElement("tranTime")]
        public string TranTime { get; set; }
        /// <summary>
        /// 交易时间 由<see cref="TranDate"/>和<see cref="TranTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.TranDate, this.TranTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 柜员交易号 char(14)
        /// </summary>
        [XmlElement("tranNo")]
        public string TranNo { get; set; }
        /// <summary>
        /// 总交易流水号 char(13)
        /// </summary>
        [XmlElement("sumTranNo")]
        public string SumTranNo { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 借贷标识 借：D，贷：C char(1)
        /// </summary>
        [XmlElement("creditDebitFlag")]
        public string CreditDebitFlag { get; set; }
        /// <summary>
        /// 对方账号 varchar(32)
        /// </summary>
        [XmlElement("oppAccountNo")]
        public string OppAccountNo { get; set; }
        /// <summary>
        /// 对方账户名称 varchar(122)
        /// </summary>
        [XmlElement("oppAccountName")]
        public string OppAccountName { get; set; }
        /// <summary>
        /// 对方开户行名 varchar(122)
        /// </summary>
        [XmlElement("oppOpenBankName")]
        public string OppOpenBankName { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 现转标识 0：现金；1：转帐 char(1)
        /// </summary>
        [XmlElement("cashTransferFlag")]
        public string CashTransferFlag { get; set; }
        /// <summary>
        /// 网银制单员 char(20)
        /// </summary>
        [XmlElement("opId")]
        public string OpId { get; set; }
        /// <summary>
        /// 制单员姓名 varchar(20)
        /// </summary>
        [XmlElement("opName")]
        public string OpName { get; set; }
        /// <summary>
        /// 网银审核员char(20)
        /// </summary>
        [XmlElement("ckId")]
        public string CkId { get; set; }
        /// <summary>
        /// 审核员姓名varchar(20)
        /// </summary>
        [XmlElement("ckName")]
        public string CkName { get; set; }
        /// <summary>
        /// 账户余额 decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 起息日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime ValueDate { get; set; }
        /// <summary>
        /// 起息日期 char(8), 对应<see cref="ValueDate"/>
        /// </summary>
        [XmlElement("valueDate")]
        public string ValueDateStr
        {
            get
            {
                return this.ValueDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ValueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 主机交易码 varchar(7)
        /// </summary>
        [XmlElement("hostTranCode")]
        public string HostTranCode { get; set; }
        /// <summary>
        /// 退汇日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime E3rtDate { get; set; }
        /// <summary>
        /// 退汇日期 char(8)，格式YYYYMMDD, 对应<see cref="E3rtDate"/>
        /// </summary>
        [XmlElement("e3rtDate")]
        public string E3rtDateStr
        {
            get
            {
                return this.E3rtDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.E3rtDate = tmp;
                }
            }
        }
        /// <summary>
        /// 退汇标志 char(1)，0：退汇；1：非退汇
        /// </summary>
        [XmlElement("e3rtFlag")]
        public string E3rtFlag { get; set; }
        /// <summary>
        /// 付款原有金额decimal (15,2)，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("oriDebitAmt")]
        public string OriDebitAmt { get; set; }
        /// <summary>
        /// 付款原有币种char(2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("oriDebitCry")]
        public string OriDebitCry { get; set; }
        /// <summary>
        /// 收款原有金额decimal(15,2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("oriCreditAmt")]
        public string OriCreditAmt { get; set; }
        /// <summary>
        /// 收款原有币种char(2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("oriCreditCry")]
        public string OriCreditCry { get; set; }
        /// <summary>
        /// 交易币种char(2) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("traCryType")]
        public string TraCryType { get; set; }
        /// <summary>
        /// 信银国际交易参考号varchar(35) ，仅当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("tranRefNo")]
        public string TranRefNo { get; set; }
        /// <summary>
        /// 客户流水号char(20)，当查询账号为信银国际账号时返回
        /// </summary>
        [XmlElement("clientId")]
        public string ClientId { get; set; }
        /// <summary>
        /// 对账编号char(20)，当客户上送controlFlag标签并且字段值为1时返回
        /// </summary>
        [XmlElement("chkNum")]
        public string ChkNum { get; set; }
        /// <summary>
        /// 关联交易日志号char(14)，当客户上送controlFlag标签并且字段值为1时返回
        /// </summary>
        [XmlElement("rlTranNo")]
        public string RlTranNo { get; set; }
        /// <summary>
        /// 冲账对方交易日期char(8)，当客户上送controlFlag标签并且字段值为1时返回
        /// </summary>
        [XmlIgnore]
        public DateTime? RfTranDt { get; set; }
        /// <summary>
        /// 冲账对方交易日期char(8), 对应<see cref="RfTranDt"/>
        /// </summary>
        [XmlElement("rfTranDt")]
        public string RfTranDtStr
        {
            get
            {
                return this.RfTranDt?.ToString("yyyyMMdd");
            }
            set
            {
                this.RfTranDt = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RfTranDt = tmp;
                }
            }
        }
        /// <summary>
        /// 冲账对方柜员交易号char(14)，当客户上送controlFlag标签并且字段值为1时返回
        /// </summary>
        [XmlElement("rfTranNo")]
        public string RfTranNo { get; set; }
    }
}
