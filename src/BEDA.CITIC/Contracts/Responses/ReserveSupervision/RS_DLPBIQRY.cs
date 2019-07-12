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
    /// 备付金账户明细查询（本行）响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPBIQRY : RsBase
    {
        /// <summary>
        /// 借方总笔数 int
        /// </summary>
        [XmlElement("rcvSum")]
        public int RcvSum { get; set; }
        /// <summary>
        /// 借方总金额 decimal(15,2)
        /// </summary>
        [XmlElement("rcvAmt")]
        public decimal RcvAmt { get; set; }
        /// <summary>
        /// 贷方总笔数 int
        /// </summary>
        [XmlElement("paySum")]
        public int PaySum { get; set; }
        /// <summary>
        /// 贷方总金额 decimal(15,2)
        /// </summary>
        [XmlElement("payAmt")]
        public decimal PayAmt { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ReserveAccTransSummary> List { get; set; }
    }
    /// <summary>
    /// 备付金账户明细（本行）
    /// </summary>
    public class ReserveAccTransSummary
    {
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
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
        /// 借贷标识 借：D，贷：C char(1)
        /// </summary>
        [XmlElement("cdfg")]
        public string Cdfg { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 账户余额 decimal(15,2)
        /// </summary>
        [XmlElement("accBal")]
        public decimal AccBal { get; set; }
        /// <summary>
        /// 凭证种类char(2)
        /// </summary>
        [XmlElement("vctp")]
        public string Vctp { get; set; }
        /// <summary>
        /// 凭证号varchar(20)
        /// </summary>
        [XmlElement("vcnm")]
        public string Vcnm { get; set; }
        /// <summary>
        /// 对手方账号 varchar(32)
        /// </summary>
        [XmlElement("otherAccNo")]
        public string OtherAccNo { get; set; }
        /// <summary>
        /// 对手方账户名称 varchar(122)
        /// </summary>
        [XmlElement("otherAccNm")]
        public string OtherAccNm { get; set; }
        /// <summary>
        /// 机构名称 varchar(122)
        /// </summary>
        [XmlElement("banknm")]
        public string Banknm { get; set; }
        /// <summary>
        /// 网点 varchar(20)
        /// </summary>
        [XmlElement("bankno")]
        public string Bankno { get; set; }
        /// <summary>
        /// 账号 varchar(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
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
        /// 退汇标志 char(1)，Y：退汇；N：非退汇
        /// </summary>
        [XmlElement("e3rtFlag")]
        public string E3rtFlag { get; set; }
    }
}
