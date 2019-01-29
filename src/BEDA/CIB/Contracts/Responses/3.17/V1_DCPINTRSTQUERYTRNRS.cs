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
    /// 3.17.3虚拟资金池利息查询响应主体
    /// </summary>
    public class V1_DCPINTRSTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.3虚拟资金池利息查询响应主体
        /// </summary>
        public DCPINTRSTQUERYTRNRS DCPINTRSTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.3虚拟资金池利息查询响应主体
    /// </summary>
    public class DCPINTRSTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.3虚拟资金池利息查询响应
        /// </summary>
        [XmlElement(Order = 2)]
        public DCPINTRSTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.3虚拟资金池利息查询响应内容
    /// </summary>
    public class DCPINTRSTQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 主账户账户代号，18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 3.17.3虚拟资金池利息查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<DCPINTRSTQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.17.3虚拟资金池利息查询响应明细
    /// </summary>
    public class DCPINTRSTQUERYTRN_CONTENT
    {
        /// <summary>
        /// 成员活期账户代号 18位
        /// </summary>
        [XmlElement(Order = 0)]
        public string MEMACCT { get; set; }
        /// <summary>
        /// 成员活期账户名称，60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string MEMACCTNAME { get; set; }
        /// <summary>
        /// 活期担保积数，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal CURRFUND { get; set; }
        /// <summary>
        /// 活期担保利息，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal CURRINTRST { get; set; }
        /// <summary>
        /// 活期担保利率，Decimal(9,7)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal CURRINTRSTRATE { get; set; }
        /// <summary>
        /// 定期担保积数，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TIMEFUND { get; set; }
        /// <summary>
        /// 定期担保利息，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal TIMEINTRST { get; set; }
        /// <summary>
        /// 定期担保利率，Decimal(9,7)
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal TIMEINTRSTRATE { get; set; }
        /// <summary>
        /// 起息日期，必回，yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起息日期，必回，yyyy-MM-dd ,对应<see cref="DTSTART"/>
        /// </summary>
        [XmlElement("DTSTART", Order = 8)]
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
        /// 结息日期，必回，yyyy-MM-dd
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 结息日期，必回，yyyy-MM-dd ,对应<see cref="DTEND"/>
        /// </summary>
        [XmlElement("DTEND", Order = 9)]
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
    }
}
