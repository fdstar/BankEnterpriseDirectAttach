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
    /// 账户明细概要信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLTRNCOL : RsBase
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
        public List<AccTransSummary> List { get; set; }
    }
    /// <summary>
    /// 账户交易明细概要信息
    /// </summary>
    public class AccTransSummary
    {
        /// <summary>
        /// 交易日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime TranDate { get; set; }
        /// <summary>
        /// 交易日期 char(8), 对应<see cref="TranDate"/>
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDateStr
        {
            get
            {
                return this.TranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TranDate = tmp;
                }
            }
        }
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
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
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
        /// 凭证种类 char(2)
        /// </summary>
        [XmlElement("voucherType")]
        public string VoucherType { get; set; }
        /// <summary>
        /// 凭证号varchar(20)
        /// </summary>
        [XmlElement("voucherName")]
        public string VoucherName { get; set; }
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
        /// <summary>
        /// 交易时间 char(6)，当客户上送controlFlag标签并且字段值为1时返回
        /// </summary>
        [XmlElement("tranTime")]
        public string TranTime { get; set; }
    }
}
