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
    /// 城市代码对照表下载响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCITCOD : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<City> List { get; set; }
    }
    /// <summary>
    /// 城市代码
    /// </summary>
    public class City
    {
        /// <summary>
        /// 城市代码char(4)
        /// </summary>
        [XmlElement("cityID")]
        public string CityID { get; set; }
        /// <summary>
        /// 城市名称varchar(20)
        /// </summary>
        [XmlElement("cityName")]
        public string CityName { get; set; }
        /// <summary>
        /// 城市英文名称 varchar(20)
        /// </summary>
        [XmlElement("cityNameEn")]
        public string CityNameEn { get; set; }
    }
}
