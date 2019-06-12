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
    /// 他行账户明细信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOACCDT : RsBase
    {
        /// <summary>
        /// 总记录条数 int
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AccTransSummaryFromOther> List { get; set; }
    }
    /// <summary>
    /// 他行账户概要信息
    /// </summary>
    public class AccTransSummaryFromOther
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
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
    }
}
