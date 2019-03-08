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
    /// 3.12.8.2定活互转同业一本通及互联互通查询响应主体
    /// </summary>
    public class V1_TRADEAPASSTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.8.2定活互转同业一本通及互联互通查询响应主体
        /// </summary>
        public TRADEAPASSTRNRS TRADEAPASSTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.8.2定活互转同业一本通及互联互通查询响应主体
    /// </summary>
    public class TRADEAPASSTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.8.2定活互转同业一本通及互联互通查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public TRADEAPASSTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.8.2定活互转同业一本通及互联互通查询响应内容
    /// </summary>
    public class TRADEAPASSTRN_RSBODY
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
        /// 同业一本通主账户及同业约定存款互联互通余额	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TRADEAPASSSUMBALANCE { get; set; }
        /// <summary>
        /// 同业一本通主账户及同业约定存款互联互通可用余额	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRADEAPASSAVAILABLEBALANCE { get; set; }
        /// <summary>
        /// 同业一本通主账户余额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TRADEMAINSUMBALANCE { get; set; }
        /// <summary>
        /// 同业一本通主账户可用余额	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TRADEMAINAVAILABLEBALANCE { get; set; }
        /// <summary>
        /// 同业约定存款互联互通余额	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal PASSSUMBALANCE { get; set; }
        /// <summary>
        /// 同业约定存款互联互通可用余额	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal PASSAVAILABLEBALANCE { get; set; }
        /// <summary>
        /// 当日同业约定存款互联互通可用额度	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal DAYPASSAVAILABLEBALANCE { get; set; }
        /// <summary>
        /// 3.12.8.2定活互转同业一本通及互联互通查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<TRADEAPASSTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.12.8.2定活互转同业一本通及互联互通查询响应明细
    /// </summary>
    public class TRADEAPASSTRN_CONTENT
    {
        /// <summary>
        /// 账户	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNUM { get; set; }
        /// <summary>
        /// 小序号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTSEQ { get; set; }
        /// <summary>
        /// 开户金额	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal OPENACCTMONEY { get; set; }
        /// <summary>
        /// 账户余额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal ACCTBALANCE { get; set; }
        /// <summary>
        /// 提前支取利率	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal ADVPAYRATE { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime OPENACCTDATE { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd ,对应<see cref="OPENACCTDATE"/>
        /// </summary>
        [XmlElement("OPENACCTDATE", Order = 6)]
        public string OPENACCTDATEStr
        {
            get
            {
                return this.OPENACCTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPENACCTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 开户机构  必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string OPENACCTMECHANISM { get; set; }
        /// <summary>
        /// 开户柜员	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string OPENACCTOPERATOR { get; set; }
    }
}
