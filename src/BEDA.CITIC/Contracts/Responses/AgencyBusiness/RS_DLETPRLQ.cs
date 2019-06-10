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
    /// 代理支付明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLETPRLQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgencyPayment> List { get; set; }
    }
    /// <summary>
    /// 代理支付明细查询
    /// </summary>
    public class AgencyPayment
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
        /// 交易码varchar(7)
        /// </summary>
        [XmlElement("tranCode")]
        public string TranCode { get; set; }
        /// <summary>
        /// 起息日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RateDate { get; set; }
        /// <summary>
        /// 起息日期char(8) 格式YYYYMMDD, 对应<see cref="RateDate"/>
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
        /// 付款账号char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 付款账户名称varchar(122)
        /// </summary>
        [XmlElement("payAccountNm")]
        public string PayAccountNm { get; set; }
        /// <summary>
        /// 付款开户行名称varchar(122)
        /// </summary>
        [XmlElement("payBankNm")]
        public string PayBankNm { get; set; }
        /// <summary>
        /// 付款开户行行号varchar(20)
        /// </summary>
        [XmlElement("payBankCode")]
        public string PayBankCode { get; set; }
        /// <summary>
        /// 客户内部账号varchar(30)
        /// </summary>
        [XmlElement("cstAccNo")]
        public string CstAccNo { get; set; }
        /// <summary>
        /// 客户内部账户名称varchar(122)
        /// </summary>
        [XmlElement("cstAccNm")]
        public string CstAccNm { get; set; }
        /// <summary>
        /// 交易金额decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 收款账号varchar(32)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 收款账户名称varchar(122)
        /// </summary>
        [XmlElement("recAccountNm")]
        public string RecAccountNm { get; set; }
        /// <summary>
        /// 收款开户行行号varchar(20)
        /// </summary>
        [XmlElement("recBankCode")]
        public string RecBankCode { get; set; }
        /// <summary>
        /// 收款开户行名称varchar(122)
        /// </summary>
        [XmlElement("recBankNm")]
        public string RecBankNm { get; set; }
        /// <summary>
        /// 中信标志char(1) 0：本行；1：他行
        /// </summary>
        [XmlElement("citicbankFlag")]
        public string CiticbankFlag { get; set; }
        /// <summary>
        /// 柜员交易号char(14)
        /// </summary>
        [XmlElement("tranNo")]
        public string TranNo { get; set; }
        /// <summary>
        /// 收费方式char(1)  0：不收费；	1:实时收费；2：汇总收费
        /// </summary>
        [XmlElement("feeType")]
        public string FeeType { get; set; }
        /// <summary>
        /// 经办人名称varchar(62)
        /// </summary>
        [XmlElement("operatorNm")]
        public string OperatorNm { get; set; }
        /// <summary>
        /// 审核人名称varchar(62)
        /// </summary>
        [XmlElement("authorNm")]
        public string AuthorNm { get; set; }
        /// <summary>
        /// 付款回单打印次数int(3)
        /// </summary>
        [XmlElement("payPrintCount")]
        public int PayPrintCount { get; set; }
        /// <summary>
        /// 收款回单打印次数int(3)
        /// </summary>
        [XmlElement("recPrintCount")]
        public int RecPrintCount { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注 varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 记录状态char(1) A：活动；C：关户；D：删除；O：预关户
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
    }
}
