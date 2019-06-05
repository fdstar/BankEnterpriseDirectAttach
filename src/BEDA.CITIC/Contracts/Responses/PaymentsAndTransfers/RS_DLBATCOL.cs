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
    /// 批量支付汇总查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBATCOL : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<PayBatchSumQry> Collection { get; set; }
    }
    /// <summary>
    /// 批量支付汇总查询
    /// </summary>
    public class PayBatchSumQry
    {
        /// <summary>
        /// 客户流水号char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 交易日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime PayDate { get; set; }
        /// <summary>
        /// 交易日期char(8) 格式YYYYMMDD, 对应<see cref="PayDate"/>
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
        /// 预约支付标志 0：非预约交易；1：预约交易 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 预约日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("preDate")]
        public string PreDate { get; set; }
        /// <summary>
        /// 预约时间char(6) 格式hhmmss
        /// </summary>
        [XmlElement("preTime")]
        public string PreTime { get; set; }
        /// <summary>
        /// 预约时间 由<see cref="PreDate"/>和<see cref="PreTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? DeferredPaymentTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.PreDate, this.PreTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 总笔数 int
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get; set; }
        /// <summary>
        /// 总金额decimal(15,2)
        /// </summary>
        [XmlElement("totalAmount")]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 摘要varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 交易状态 char(7) ，值域参见见附录4.8
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
    }
}
