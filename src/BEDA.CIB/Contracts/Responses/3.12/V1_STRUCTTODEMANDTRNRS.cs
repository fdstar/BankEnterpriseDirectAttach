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
    /// 3.12.6.5定活互转结构性存款支取响应主体
    /// </summary>
    public class V1_STRUCTTODEMANDTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.6.5定活互转结构性存款支取响应主体
        /// </summary>
        public STRUCTTODEMANDTRNRS STRUCTTODEMANDTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.6.5定活互转结构性存款支取响应主体
    /// </summary>
    public class STRUCTTODEMANDTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.6.5定活互转结构性存款支取响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public STRUCTTODEMANDTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.5定活互转结构性存款支取响应内容
    /// </summary>
    public class STRUCTTODEMANDTRN_RSBODY
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
        /// 结构性存款账号
        /// </summary>
        [XmlElement(Order = 3)]
        public string STRUCTACCT { get; set; }
        /// <summary>
        /// 结构性存款产品序号
        /// </summary>
        [XmlElement(Order = 4)]
        public string PRODUCTNO { get; set; }
        /// <summary>
        /// 结构性存款产品期限
        /// </summary>
        [XmlElement(Order = 7)]
        public string PRODUCTTERM { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime OPENDATE { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd ,对应<see cref="OPENDATE"/>
        /// </summary>
        [XmlElement("OPENDATE", Order = 10)]
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
        /// 起息日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 11)]
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
        [XmlElement("DTEND", Order = 12)]
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
        /// 支取金额，decimal(17,2)
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 开户金额
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal OPENAMOUNT { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement(Order = 16)]
        public decimal BALANCE { get; set; }
        /// <summary>
        /// 参考执行利率：支取日期晚于开户日期与产品期限之和，参考执行利率为客户收益率；支取日期早于开户日期与产品期限之和，参考执行利率为提前支取收益率
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal REFERRATE { get; set; }
        /// <summary>
        /// 试算利息：支取金额* 参考执行利率*((支取日期-起息日期)/365)
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal CALINTEREST { get; set; }
        /// <summary>
        /// 账户状态
        /// </summary>
        [XmlElement(Order = 20)]
        public string ACCTSTATUS { get; set; }
        /// <summary>
        /// 最低支取金额
        /// </summary>
        [XmlElement(Order = 21)]
        public decimal MINPROFITAMT { get; set; }
        /// <summary>
        /// 支取递增金额
        /// </summary>
        [XmlElement(Order = 22)]
        public decimal PROFITINCREASEAMT { get; set; }
        /// <summary>
        /// 最低留存金额
        /// </summary>
        [XmlElement(Order = 23)]
        public decimal RETAINEDAMOUNT { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 30)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
