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
    /// 货币代码对照表下载响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCURCOD : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<Currency> List { get; set; }
    }
    /// <summary>
    /// 货币代码
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// 货币代码 char(2)
        /// </summary>
        [XmlElement("currencyID")]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 货币名称varchar(20)
        /// </summary>
        [XmlElement("currencyName")]
        public string CurrencyName { get; set; }
        /// <summary>
        /// 货币英文名称 varchar(20)
        /// </summary>
        [XmlElement("currencyNameEn")]
        public string CurrencyNameEn { get; set; }
    }
}
