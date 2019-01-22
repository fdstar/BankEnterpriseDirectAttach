using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 集团服务查询成员外部收支明细响应主体
    /// </summary>
    public class V1_CMMEMSTMTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 集团服务查询成员外部收支明细响应主体
        /// </summary>
        public CMMEMSTMTQUERYTRNRS CMMEMSTMTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 集团服务查询成员外部收支明细响应主体
    /// </summary>
    public class CMMEMSTMTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 集团服务查询成员外部收支明细响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CMMEMSTMTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 集团服务查询成员外部收支明细响应内容
    /// </summary>
    public class CMMEMSTMTQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 成员单位账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT MBRACCT { get; set; }
        /// <summary>
        /// 集团服务查询成员外部收支明细集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CMMEMSTMTQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 集团服务查询成员外部收支明细内容
    /// </summary>
    public class CMMEMSTMTQUERYTRN_CONTENT
    {
        /// <summary>
        /// 对方单位账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string CORRELATE_ACCTID { get; set; }
        /// <summary>
        /// 对方单位户名，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string CORRELATE_NAME { get; set; }
        /// <summary>
        /// 记账日期，YYYY-MM-DD
        /// </summary>
        [XmlElement(Order = 2)]
        public string DTACCT { get; set; }
        /// <summary>
        /// 记账时间,HH:MM:SS
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
                if (DateTime.TryParseExact(DTACCT + TMACCT, new string[] { "yyyy-MM-dd", "yyyy-MM-ddHH:mm:ss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime time))
                {
                    return time;
                }
                return null;
            }
            set
            {
                this.DTACCT = value?.ToString("yyyy-MM-dd");
                this.TMACCT = value?.ToString("HH:mm:ss");
            }
        }
        /// <summary>
        /// 凭证代号，最长9位
        /// </summary>
        [XmlElement(Order = 4)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 核心摘要简称
        /// </summary>
        [XmlElement(Order = 5)]
        public string SUMM { get; set; }
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement(Order = 6)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 现转标识 1 转 0 现
        /// </summary>
        [XmlElement(Order = 7)]
        public int NTFLAG { get; set; }
        /// <summary>
        /// 借贷标识 0借 1 贷
        /// </summary>
        [XmlElement(Order = 8)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 交易金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 可用额度，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal AVAILBAL { get; set; }
    }
}
