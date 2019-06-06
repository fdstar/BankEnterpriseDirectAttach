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
    /// 其它代发汇总查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOTHCOL : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<OtherPaymentSummary> Collection { get; set; }
    }
    /// <summary>
    /// 其它代发汇总
    /// </summary>
    public class OtherPaymentSummary
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
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
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
    }
}
