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
    /// 他行交易明细信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOACTDT : RsBase
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
        public List<AccTransDetailFromOther> List { get; set; }
    }
    /// <summary>
    /// 他行账户交易明细信息
    /// </summary>
    public class AccTransDetailFromOther
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
        /// 币种英文名称-varchar(20)
        /// </summary>
        [XmlElement("cryTypeEn")]
        public string CryTypeEn { get; set; }
    }
}
