using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts
{
    /// <summary>
    /// 日期范围
    /// </summary>
    public class DATERANGE
    {
        /// <summary>
        /// 起始日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? DTSTART { get; set; }
        /// <summary>
        /// 起始日期 YYYY-MM-DD ,对应<see cref="DTSTART"/> 非必输
        /// </summary>
        [XmlElement("DTSTART", Order = 3)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTSTART = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 终止日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? DTEND { get; set; }
        /// <summary>
        /// 终止日期 YYYY-MM-DD ,对应<see cref="DTEND"/>	非必输
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
    }
    /// <summary>
    /// 票据金额范围
    /// </summary>
    public class AMTRANGE
    {
        /// <summary>
        /// 最小金额,17位(15整数位,2小数位)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最小金额,17位(15整数位,2小数位) 对应<see cref="MINAMT"/>	非必输
        /// </summary>
        [XmlElement("MINAMT", Order = 0)]
        public string MINAMTStr
        {
            get
            {
                return this.MINAMT?.ToString();
            }
            set
            {
                this.MINAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 最大金额,17位(15整数位,2小数位)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 最大金额,17位(15整数位,2小数位) 对应<see cref="MAXAMT"/>	非必输
        /// </summary>
        [XmlElement("MAXAMT", Order = 1)]
        public string MAXAMTStr
        {
            get
            {
                return this.MAXAMT?.ToString();
            }
            set
            {
                this.MAXAMT = value.TryConvert<decimal>();
            }
        }
    }
}
