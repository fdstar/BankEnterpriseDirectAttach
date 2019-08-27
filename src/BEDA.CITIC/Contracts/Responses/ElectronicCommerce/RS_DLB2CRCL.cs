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
    /// B2C商户退款汇总查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLB2CRCL : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<B2CMerchantRefundSummary> List { get; set; }
    }
    /// <summary>
    /// B2C商户退款汇总
    /// </summary>
    public class B2CMerchantRefundSummary
    {
        /// <summary>
        /// 批次号 varchar(8)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 借记卡总笔数 int
        /// </summary>
        [XmlElement("debitTotal")]
        public int DebitTotal { get; set; }
        /// <summary>
        /// 借记卡总金额 decimal(15,2)
        /// </summary>
        [XmlElement("debitAmt")]
        public decimal DebitAmt { get; set; }
        /// <summary>
        /// 信用卡总笔数 int
        /// </summary>
        [XmlElement("creditTotal")]
        public int CreditTotal { get; set; }
        /// <summary>
        /// 信用卡总金额 decimal(15,2)
        /// </summary>
        [XmlElement("creditAmt")]
        public decimal CreditAmt { get; set; }
        /// <summary>
        /// 成功总笔数 int
        /// </summary>
        [XmlElement("succTotal")]
        public int SuccTotal { get; set; }
        /// <summary>
        /// 成功总金额 decimal(15,2)
        /// </summary>
        [XmlElement("succAmt")]
        public decimal SuccAmt { get; set; }
        /// <summary>
        /// 失败总笔数 int
        /// </summary>
        [XmlElement("failTotal")]
        public int FailTotal { get; set; }
        /// <summary>
        /// 失败总金额 decimal(15,2)
        /// </summary>
        [XmlElement("failAmt")]
        public decimal FailAmt { get; set; }
        /// <summary>
        /// 批次受理状态 varchar(2)，值域见附录4.2
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
        /// <summary>
        /// 退款日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDate { get; set; }
        /// <summary>
        /// 退款时间char(6) 格式hhmmss
        /// </summary>
        [XmlElement("tranTime")]
        public string TranTime { get; set; }
        /// <summary>
        /// 退款时间 由<see cref="TranDate"/>和<see cref="TranTime"/>组成
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
    }
}
