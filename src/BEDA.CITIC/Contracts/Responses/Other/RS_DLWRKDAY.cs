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
    /// 工作日下载响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLWRKDAY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<WorkDay> List { get; set; }
    }
    /// <summary>
    /// 工作日
    /// </summary>
    public class WorkDay
    {
        /// <summary>
        /// 日期 char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime Date { get; set; }
        /// <summary>
        /// 日期 char(8), 对应<see cref="Date"/>
        /// </summary>
        [XmlElement("date")]
        public string DateStr
        {
            get
            {
                return this.Date.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.Date = tmp;
                }
            }
        }
        /// <summary>
        /// 是否工作日 W：工作日；N：非工作日 char(1)
        /// </summary>
        [XmlElement("workFlag")]
        public string WorkFlag { get; set; }
    }
}
