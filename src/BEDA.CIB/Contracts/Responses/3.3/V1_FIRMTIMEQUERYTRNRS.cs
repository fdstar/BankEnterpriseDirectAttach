using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.3.8单位定期一本通账户查询响应主体
    /// </summary>
    public class V1_FIRMTIMEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.3.8单位定期一本通账户查询响应
        /// </summary>
        public FIRMTIMEQUERYTRNRS FIRMTIMEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.3.8单位定期一本通账户查询响应
    /// </summary>
    public class FIRMTIMEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.3.8非定期存款账户信息，必回
        /// </summary>
        [XmlElement(Order = 2)]
        public FIRMTIMEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.3.8单位定期一本通账户查询结果集合
    /// </summary>
    public class FIRMTIMEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否还有下一页：Y－有,N－否
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 定期一本通总账号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 累计金额，2位小数
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal SUMAMT { get; set; }
        /// <summary>
        /// 3.3.8查询结果集合
        /// </summary>
        [XmlElement("CONTENT", Order = 3)]
        public List<FIRMTIMEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.3.8单位定期一本通账户查询结果明细
    /// </summary>
    public class FIRMTIMEQUERYTRN_CONTENT
    {
        /// <summary>
        /// 账号序号，最长6位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNUM { get; set; }
        /// <summary>
        /// 账户余额，2位小数
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 定期账户状态
        /// </summary>
        [XmlElement(Order = 2)]
        public string STATUS { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 3)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime? DTEND { get; set; }
        /// <summary>
        /// 到期日期，格式yyyy-MM-dd ,对应<see cref="DTEND"/>
        /// </summary>
        [XmlElement("DTEND", Order = 4)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTEND = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 存期
        /// </summary>
        [XmlElement(Order = 5)]
        public string TERM { get; set; }
        /// <summary>
        /// 续存标志
        /// </summary>
        [XmlElement(Order = 6)]
        public string CONTFLAG { get; set; }
        /// <summary>
        /// 续存存期
        /// </summary>
        [XmlElement(Order = 7)]
        public string TERMTYPE { get; set; }
        /// <summary>
        /// 销户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime? CANCALDATE { get; set; }
        /// <summary>
        /// 到期日期，格式yyyy-MM-dd ,对应<see cref="CANCALDATE"/>
        /// </summary>
        [XmlElement("DTEND", Order = 8)]
        public string CANCALDATEStr
        {
            get
            {
                return this.CANCALDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.CANCALDATE = value.TryConvert<DateTime>();
            }
        }
    }
}
