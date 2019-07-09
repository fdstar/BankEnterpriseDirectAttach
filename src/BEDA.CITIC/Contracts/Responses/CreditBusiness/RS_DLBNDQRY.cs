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
    /// 授信额度信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBNDQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CreditLine> List { get; set; }
    }
    /// <summary>
    /// 授信额度信息
    /// </summary>
    public class CreditLine
    {
        /// <summary>
        /// 批复流水号 char(20)
        /// </summary>
        [XmlElement("flowNo")]
        public string FlowNo { get; set; }
        /// <summary>
        /// 业务类型 varchar(60)
        /// </summary>
        [XmlElement("kind")]
        public string Kind { get; set; }
        /// <summary>
        /// 币种 char(2) ”01”为人民币
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 授信总额度 decimal(15,2)
        /// </summary>
        [XmlElement("totalAmt")]
        public decimal TotalAmt { get; set; }
        /// <summary>
        /// 可用总额度 decimal(15,2)
        /// </summary>
        [XmlElement("avaiTotalAmt")]
        public decimal AvaiTotalAmt { get; set; }
        /// <summary>
        /// 已用额度 decimal(15,2)
        /// </summary>
        [XmlElement("usedAmt")]
        public decimal UsedAmt { get; set; }
        /// <summary>
        /// 可用额度 decimal(15，2)
        /// </summary>
        [XmlElement("avaiAmt")]
        public decimal AvaiAmt { get; set; }
        /// <summary>
        /// 有效期 char(2)月数
        /// </summary>
        [XmlElement("avaiDate")]
        public string AvaiDate { get; set; }
        /// <summary>
        /// 额度生效日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 额度生效日 char(8) 格式YYYYMMDD, 对应<see cref="StartDate"/>
        /// </summary>
        [XmlElement("startDate")]
        public string StartDateStr
        {
            get
            {
                return this.StartDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartDate = tmp;
                }
            }
        }
        /// <summary>
        /// 额度到期日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 额度到期日 char(8) 格式YYYYMMDD, 对应<see cref="DueDate"/>
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
    }
}
