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
    /// 组合型智能存款利息明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFDQZLQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MixedTypeAIDepositInterestDetail> List { get; set; }
    }
    /// <summary>
    /// 组合型智能存款利息明细
    /// </summary>
    public class MixedTypeAIDepositInterestDetail
    {
        /// <summary>
        /// 起存日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 起存日期char(8)，格式YYYYMMDD, 对应<see cref="StartDate"/>
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
        /// 支取日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DrawDate { get; set; }
        /// <summary>
        /// 支取日期char(8)，格式YYYYMMDD, 对应<see cref="DrawDate"/>
        /// </summary>
        [XmlElement("drawDate")]
        public string DrawDateStr
        {
            get
            {
                return this.DrawDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DrawDate = tmp;
                }
            }
        }
        /// <summary>
        /// 支取金额decimal(15,2)
        /// </summary>
        [XmlElement("drawAmt")]
        public decimal DrawAmt { get; set; }
        /// <summary>
        /// 实存天varchar(254)
        /// </summary>
        [XmlElement("inDays")]
        public string InDays { get; set; }
        /// <summary>
        /// 匹配储种 char(3) D01：1天通知；D07：7天通知；M03：3个月定期；M06：6个月定期；Y01：12个月定期；000：储种为空
        /// </summary>
        [XmlElement("mtPerd")]
        public string MtPerd { get; set; }
        /// <summary>
        /// 匹配利率 decimal(9,7)
        /// </summary>
        [XmlElement("mtRate")]
        public decimal MtRate { get; set; }
        /// <summary>
        /// 利息decimal(15,2)
        /// </summary>
        [XmlElement("inrt")]
        public decimal Inrt { get; set; }
        /// <summary>
        /// 利息状态char(1) 0：未收；1：已收
        /// </summary>
        [XmlElement("inrtStatus")]
        public int InrtStatus { get; set; }
        /// <summary>
        /// 收息日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime RcvDate { get; set; }
        /// <summary>
        /// 收息日期char(8)，格式YYYYMMDD, 对应<see cref="RcvDate"/>
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
    }
}
