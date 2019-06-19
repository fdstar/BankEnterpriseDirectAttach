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
    /// 成员单位利息计算经办查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPPCQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<UnitInterest> List { get; set; }
    }
    /// <summary>
    /// 成员单位利息计算
    /// </summary>
    public class UnitInterest
    {
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 成员单位账户名称 varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 应付利息 decimal(15,2)
        /// </summary>
        [XmlElement("payAmt")]
        public decimal PayAmt { get; set; }
        /// <summary>
        /// 应收利息 decimal(15,2)
        /// </summary>
        [XmlElement("rcvAmt")]
        public decimal RcvAmt { get; set; }
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
        /// 结息日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 结息日期 char(8) 格式YYYYMMDD, 对应<see cref="DueDate"/>
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
        /// 本期归集利率 decimal(9,7)
        /// </summary>
        public decimal XSGJLL { get; set; }
        /// <summary>
        /// 本期归集积数 decimal(15,2)
        /// </summary>
        public decimal XSGJJS { get; set; }
        /// <summary>
        /// 本期归集应收利息 decimal(15,2)
        /// </summary>
        public decimal XSGJLX { get; set; }
        /// <summary>
        /// 本期归集下拨占用利率 decimal(9,7)
        /// </summary>
        public decimal XSCGLL { get; set; }
        /// <summary>
        /// 本期归集下拨占用积数 decimal(15,2)
        /// </summary>
        public decimal XSCGJS { get; set; }
        /// <summary>
        /// 本期归集下拨应付利息 decimal(15,2)
        /// </summary>
        public decimal XSCGLX { get; set; }
        /// <summary>
        /// 本期日终填平占用利率 decimal(9,7)
        /// </summary>
        public decimal XSTZLL { get; set; }
        /// <summary>
        /// 本期日终填平占用积数 decimal(15,2)
        /// </summary>
        public decimal XSTZJS { get; set; }
        /// <summary>
        /// 本期日终填平占用应付利息 decimal(15,2)
        /// </summary>
        public decimal XSTZLX { get; set; }
        /// <summary>
        /// 本期日终填平上存利率 decimal(9,7)
        /// </summary>
        public decimal XSTCLL { get; set; }
        /// <summary>
        /// 本期日终填平上存积数 decimal(15,2)
        /// </summary>
        public decimal XSTCJS { get; set; }
        /// <summary>
        /// 本期日终填平上存应收利息 decimal(15,2)
        /// </summary>
        public decimal XSTCLX { get; set; }
    }
}
