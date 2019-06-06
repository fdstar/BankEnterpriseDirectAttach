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
    /// 代发工资汇总查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSALCOL : RsBase
    {
        /// <summary>
        /// 代发年月char(6) 格式YYYYMM
        /// </summary>
        [XmlElement("yearMonth")]
        public string YearMonth { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AgencySummary> Collection { get; set; }
    }
    /// <summary>
    /// 代发汇总
    /// </summary>
    public class AgencySummary
    {
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 交易日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime PayDate { get; set; }
        /// <summary>
        /// 交易日期 char(8), 对应<see cref="PayDate"/>
        /// </summary>
        [XmlElement("payDate")]
        public string PayDateStr
        {
            get
            {
                return this.PayDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PayDate = tmp;
                }
            }
        }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 总笔数 int
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get; set; }
        /// <summary>
        /// 总金额 decimal(15,2)
        /// </summary>
        [XmlElement("totalAmount")]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 状态代码 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 状态信息含义 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
        /// <summary>
        /// 短信摘要 char(1)  1：代发工资；2：代发奖金；3：代发津贴；4：代发劳保福利；5：代发财务报销；6：代发拆迁款；7：代发其他
        /// </summary>
        [XmlElement("msgAbstract")]
        public int MsgAbstract { get; set; }
    }
}
