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
    /// ECDS查询查复历史信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBADEHQ : RsBase
    {
        /// <summary>
        /// 总笔数int
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 票据号varchar(16)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 票据类型char(4)，AC01：银承；AC02：商承
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 票面金额decimal(15,2)
        /// </summary>
        [XmlElement("billAmt")]
        public decimal BillAmt { get; set; }
        /// <summary>
        /// 出票日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime IssDate { get; set; }
        /// <summary>
        /// 出票日期char(8)，格式YYYYMMDD, 对应<see cref="IssDate"/>
        /// </summary>
        [XmlElement("issDate")]
        public string IssDateStr
        {
            get
            {
                return this.IssDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.IssDate = tmp;
                }
            }
        }
        /// <summary>
        /// 票据到期日char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 票据到期日char(8)，格式YYYYMMDD, 对应<see cref="DueDate"/>
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
        /// 付款人开户行行号varchar(20)
        /// </summary>
        [XmlElement("payBankNo")]
        public string PayBankNo { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ECDSQueryHistory> List { get; set; }
    }
    /// <summary>
    /// ECDS查询查复历史信息
    /// </summary>
    public class ECDSQueryHistory
    {
        /// <summary>
        /// 历史查询行号varchar(20)
        /// </summary>
        [XmlElement("hisQryBankNo")]
        public string HisQryBankNo { get; set; }
        /// <summary>
        /// 历史查询日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlElement("hisQryDate")]
        public string HisQryDate { get; set; }
        /// <summary>
        /// 历史查询时间char(6)，格式hhmmss
        /// </summary>
        [XmlElement("hisQryTime")]
        public string HisQryTime { get; set; }
        /// <summary>
        /// 经办时间 由<see cref="HisQryDate"/>和<see cref="HisQryTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? HistoryQueryTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.HisQryDate, this.HisQryTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
    }
}
