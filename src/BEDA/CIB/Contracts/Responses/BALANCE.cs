using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 余额
    /// </summary>
    public class BALANCE
    {
        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement(Order = 0)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 日期 yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTASOF { get; set; }
        /// <summary>
        /// 起始日期，必回，yyyy-MM-dd ,对应<see cref="DTASOF"/>
        /// </summary>
        [XmlElement("DTASOF", Order = 1)]
        public string DTASOFStr
        {
            get
            {
                return this.DTASOF.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTASOF = tmp;
                }
            }
        }
    }
}
