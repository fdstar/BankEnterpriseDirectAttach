using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 集团账户成员交易明细查询响应主体
    /// </summary>
    public class V1_CMSTMTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 集团账户成员交易明细查询响应
        /// </summary>
        public CMSTMTQUERYTRNRS CMSTMTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 集团账户成员交易明细查询响应
    /// </summary>
    public class CMSTMTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 集团账户成员交易明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CMINNERQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 集团账户成员交易明细查询响应内容
    /// </summary>
    public class CMINNERQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 集团账户成员交易明细集合
        /// </summary>
        [XmlElement("CONTENT")]
        public List<CMINNERQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 集团账户成员交易明细
    /// </summary>
    public class CMINNERQUERYTRN_CONTENT
    {
        /// <summary>
        /// 结算中心信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户代号
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCT MBRACCT { get; set; }
        /// <summary>
        /// 记账日期YYYY-MM-DD
        /// </summary>
        [XmlElement(Order = 2)]
        public string DTACCT { get; set; }
        /// <summary>
        /// 记账时间HHmmss – 6位
        /// </summary>
        [XmlElement(Order = 3)]
        public string TMACCT { get; set; }
        /// <summary>
        /// 记账时间，如果获取失败则返回null
        /// </summary>
        [XmlIgnore]
        public DateTime? AccountingTime
        {
            get
            {
                if(DateTime.TryParseExact(DTACCT+ TMACCT, "yyyy-MM-ddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime time))
                {
                    return time;
                }
                return null;
            }
            set
            {
                this.DTACCT = value?.ToString("yyyy-MM-dd");
                this.TMACCT = value?.ToString("HHmmss");
            }
        }
        /// <summary>
        /// 凭证类型 2位
        /// </summary>
        [XmlElement(Order = 4)]
        public string CHEQUETYPE { get; set; }
        /// <summary>
        /// 凭证号 最长9位
        /// </summary>
        [XmlElement(Order = 5)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 交易流水号 8位
        /// </summary>
        [XmlElement(Order = 6)]
        public string SEQ { get; set; }
        /// <summary>
        /// 摘要 3位
        /// </summary>
        [XmlElement(Order = 7)]
        public string SUMM { get; set; }
        /// <summary>
        /// 币种,2位
        /// </summary>
        [XmlElement(Order = 8)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 现转标识 0  现金 1  转账 A  单方（未确认，核心查出的）
        /// </summary>
        [XmlElement(Order = 9)]
        public string NTFLAG { get; set; }
        /// <summary>
        /// 借贷标识 0 借 1 贷 2 开户(表外) 3 换折  4 做废      （未确认，核心查出的）
        /// </summary>
        [XmlElement(Order = 10)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 交易金额，decimal(15,2)，即整数最长13位，小数2位
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 账户余额，decimal(15,2)，即整数最长13位，小数2位
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 对方账户代号信息
        /// </summary>
        [XmlElement(Order = 13)]
        public CORRELATEACCT CORRELATE_ACCT { get; set; }
        /// <summary>
        /// 业务类型 ，保留，暂未返回，预留20位
        /// </summary>
        [XmlElement(Order = 14)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 附加信息，网点名称，保留，暂未返回，预留60位
        /// </summary>
        [XmlElement(Order = 15)]
        public string CORRELATEINFO { get; set; }
        /// <summary>
        /// 备注，最长60位
        /// </summary>
        [XmlElement(Order = 16)]
        public string MEMO { get; set; }
    }
}
