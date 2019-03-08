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
    /// 3.12.6.2定活互转结构性存款开户响应主体
    /// </summary>
    public class V1_DEMANDTOSTRUCTTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.6.2定活互转结构性存款开户响应主体
        /// </summary>
        public DEMANDTOSTRUCTTRNRS DEMANDTOSTRUCTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.6.2定活互转结构性存款开户响应主体
    /// </summary>
    public class DEMANDTOSTRUCTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.6.2定活互转结构性存款开户响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DEMANDTOSTRUCTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.2定活互转结构性存款开户响应内容
    /// </summary>
    public class DEMANDTOSTRUCTTRN_RSBODY
    {
        /// <summary>
        /// 活期账号
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCT { get; set; }
        /// <summary>
        /// 活期账号名称
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCTNAME { get; set; }
        /// <summary>
        /// 活期账户余额
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal BALANCE { get; set; }
        /// <summary>
        /// 活期账户可用余额
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AVAILBALANCE { get; set; }
        /// <summary>
        /// 结构性存款产品序号
        /// </summary>
        [XmlElement(Order = 5)]
        public string PRODUCTNO { get; set; }
        /// <summary>
        /// 结构性存款产品名称
        /// </summary>
        [XmlElement(Order = 6)]
        public string PRODUCTNAME { get; set; }
        /// <summary>
        /// 结构性存款产品类型
        /// </summary>
        [XmlElement(Order = 7)]
        public string PRODUCTTYPE { get; set; }
        /// <summary>
        /// 结构性存款产品期限
        /// </summary>
        [XmlElement(Order = 8)]
        public string PRODUCTTERM { get; set; }
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement(Order = 9)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 参考利率，即客户收益率
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal REFERRATE { get; set; }
        /// <summary>
        /// 起存金额
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal MINOPENAMOUNT { get; set; }
        /// <summary>
        /// 递增金额
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal INCREASEAMOUNT { get; set; }
        /// <summary>
        /// 剩余额度
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal LEFTEDBALANCE { get; set; }
        /// <summary>
        /// 结构性存款账号
        /// </summary>
        [XmlElement(Order = 14)]
        public string STRUCTACCT { get; set; }
        /// <summary>
        /// 开户金额
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime? OPENDATE { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd ,对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 16)]
        public string OPENDATEStr
        {
            get
            {
                return this.OPENDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.OPENDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPENDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 17)]
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
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 到期日期，格式yyyy-MM-dd ,对应<see cref="DTEND"/>
        /// </summary>
        [XmlElement("DTEND", Order = 18)]
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
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 30)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
