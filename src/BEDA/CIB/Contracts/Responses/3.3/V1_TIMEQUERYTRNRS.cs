using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 定期账户查询响应主体
    /// </summary>
    public class V1_TIMEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 定期账户查询响应
        /// </summary>
        public TIMEQUERYTRNRS TIMEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 定期账户查询响应
    /// </summary>
    public class TIMEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 定期账户查询集合
        /// </summary>
        [XmlElement(Order = 2)]
        public TIMERSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 定期账户查询结果集合
    /// </summary>
    public class TIMERSBODY
    {
        /// <summary>
        /// 是否还有下一页：Y－有,N－否
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 定期账户集合，非必回
        /// </summary>
        [XmlElement("CONTENT")]
        public List<TIMECONTENT> List { get; set; }
    }
    /// <summary>
    /// 定期账户响应
    /// </summary>
    public class TIMECONTENT
    {
        /// <summary>
        /// 定期账号，长度18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string TIMEACCTID { get; set; }
        /// <summary>
        /// 定期账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string TIMENAME { get; set; }
        /// <summary>
        /// 凭证代号，长度9位
        /// </summary>
        [XmlElement(Order = 2)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 开户金额，2位小数
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal OPENAMT { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime OPENDATE { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd ,对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 4)]
        public string OPENDATEStr
        {
            get
            {
                return this.OPENDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPENDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 利率，7位小数
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal INTRST { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 6)]
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
        /// 定期账户余额，2位小数
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 到期日，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 到期日，格式yyyy-MM-dd ,对应<see cref="DTEND"/>
        /// </summary>
        [XmlElement("DTEND", Order = 8)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement(Order = 9)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 存期
        /// </summary>
        [XmlElement(Order = 10)]
        public string TERM { get; set; }
        /// <summary>
        /// 续存标志
        /// </summary>
        [XmlElement(Order = 11)]
        public string CONTFLAG { get; set; }
        /// <summary>
        /// 续存存期
        /// </summary>
        [XmlElement(Order = 12)]
        public string TERMTYPE { get; set; }
        /// <summary>
        /// 定期账户状态: 1-有效 2-销户 4-冻结 C-抵押
        /// </summary>
        [XmlElement(Order = 13)]
        public string STATUS { get; set; }
        /// <summary>
        /// 定期账户类型: 0-普通定期 2-智能定期  3-普通通知 4-智能通知 5-结构性存款 6-新型结构性存款
        /// </summary>
        [XmlElement(Order = 14)]
        public int TIMETYPE { get; set; }
    }
}
