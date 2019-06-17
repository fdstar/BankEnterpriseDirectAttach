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
    /// 内部利率查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPLPMQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<InternalInterestRate> List { get; set; }
    }
    /// <summary>
    /// 内部利率查询
    /// </summary>
    public class InternalInterestRate
    {
        /// <summary>
        /// 核心账号 char(19)
        /// </summary>
        [XmlElement("coreAccNo")]
        public string CoreAccNo { get; set; }
        /// <summary>
        /// 现金池ID char(8)
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 归集利率 decimal(9,7)
        /// </summary>
        [XmlElement("collRate")]
        public decimal CollRate { get; set; }
        /// <summary>
        /// 超归集下拨利率 decimal(9,7)
        /// </summary>
        [XmlElement("supRate")]
        public decimal SupRate { get; set; }
        /// <summary>
        /// 日终填平占用利率 decimal(9,7)
        /// </summary>
        [XmlElement("dayFillUsRate")]
        public decimal DayFillUsRate { get; set; }
        /// <summary>
        /// 日终填平上存利率 decimal(9,7)
        /// </summary>
        [XmlElement("dayFillUpRate")]
        public decimal DayFillUpRate { get; set; }
        /// <summary>
        /// 归集利率是否使用银行利率 char(1) 0：不使用；1：使用
        /// </summary>
        [XmlElement("collRateBankFlag")]
        public int CollRateBankFlag { get; set; }
        /// <summary>
        /// 超归集下拨利率是否使用银行利率 char(1) 0：不使用；1使用
        /// </summary>
        [XmlElement("supRateBankFlag")]
        public int SupRateBankFlag { get; set; }
        /// <summary>
        /// 日终填平占用利率是否使用银行利率 char(1) 0：不使用；1：使用
        /// </summary>
        [XmlElement("dayFillUsRateBankFlag")]
        public int DayFillUsRateBankFlag { get; set; }
        /// <summary>
        /// 日终填平上存利率是否使用银行利率 char(1) 0：不使用；1使用
        /// </summary>
        [XmlElement("dayFillUpRateBankFlag")]
        public int DayFillUpRateBankFlag { get; set; }
    }
}
