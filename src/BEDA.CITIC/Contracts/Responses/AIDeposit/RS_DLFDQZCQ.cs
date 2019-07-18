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
    /// 组合型智能存款利息汇总查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFDQZCQ : RsBase
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
        public List<MixedTypeAIDepositInterestSummary> List { get; set; }
    }
    /// <summary>
    /// 组合型智能存款利息汇总
    /// </summary>
    public class MixedTypeAIDepositInterestSummary
    {
        /// <summary>
        /// 利息金额decimal(15,2)
        /// </summary>
        [XmlElement("inrtAmt")]
        public decimal InrtAmt { get; set; }
        /// <summary>
        /// 入息日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RcvDate { get; set; }
        /// <summary>
        /// 入息日期char(8)，格式YYYYMMDD, 对应<see cref="RcvDate"/>
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
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 活期利息decimal(15,2)
        /// </summary>
        [XmlElement("curInrt")]
        public decimal CurInrt { get; set; }
        /// <summary>
        /// 定期利息decimal(15,2)
        /// </summary>
        [XmlElement("fixInrt")]
        public decimal FixInrt { get; set; }
        /// <summary>
        /// 年份char(4)
        /// </summary>
        [XmlElement("xtYear")]
        public int XtYear { get; set; }
        /// <summary>
        /// 季度 char(1) 1：第一季度；2：第二季度；3：第三季度；4：第四季度
        /// </summary>
        [XmlElement("xtQuarter")]
        public int XtQuarter { get; set; }
    }
}
