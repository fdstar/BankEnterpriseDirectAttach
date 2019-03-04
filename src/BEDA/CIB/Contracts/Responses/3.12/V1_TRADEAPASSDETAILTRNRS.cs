using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.12.8.1定活互转一本帐及互联互通响应主体
    /// </summary>
    public class V1_TRADEAPASSDETAILTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.8.1定活互转一本帐及互联互通响应主体
        /// </summary>
        public TRADEAPASSDETAILTRNRS TRADEAPASSDETAILTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.8.1定活互转一本帐及互联互通响应主体
    /// </summary>
    public class TRADEAPASSDETAILTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.8.1定活互转一本帐及互联互通响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public TRADEAPASSDETAILTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.8.1定活互转一本帐及互联互通响应内容
    /// </summary>
    public class TRADEAPASSDETAILTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 同业一本通账户汇总余额	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal ACCTSUM { get; set; }
        /// <summary>
        /// 3.12.8.1定活互转一本帐及互联互通响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<TRADEAPASSDETAILTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.12.8.1定活互转一本帐及互联互通响应明细
    /// </summary>
    public class TRADEAPASSDETAILTRN_CONTENT
    {
        /// <summary>
        /// 小序号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string SERIALNUM { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime VALUEDATE { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd ,对应<see cref="VALUEDATE"/>
        /// </summary>
        [XmlElement("VALUEDATE", Order = 2)]
        public string VALUEDATEStr
        {
            get
            {
                return this.VALUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VALUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 存期	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string DEPOSITTERM { get; set; }
        /// <summary>
        /// 账户余额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal ACCTBALANCE { get; set; }
        /// <summary>
        /// 到期日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime? DUEDATE { get; set; }
        /// <summary>
        /// 到期日期，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE", Order = 5)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DUEDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 续存标记   必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string RENEWMARK { get; set; }
        /// <summary>
        /// 续存存期	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string RENEWTERM { get; set; }
        /// <summary>
        /// 销户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime? CLOSEACCTDATE { get; set; }
        /// <summary>
        /// 销户日期，格式yyyy-MM-dd ,对应<see cref="CLOSEACCTDATE"/>
        /// </summary>
        [XmlElement("CLOSEACCTDATE", Order = 8)]
        public string CLOSEACCTDATEStr
        {
            get
            {
                return this.CLOSEACCTDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.CLOSEACCTDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CLOSEACCTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 记录状态	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string STATUSRECORD { get; set; }
    }
}
