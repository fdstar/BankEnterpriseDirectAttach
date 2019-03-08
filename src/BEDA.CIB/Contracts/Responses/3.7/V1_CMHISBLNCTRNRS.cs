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
    /// 历史留存金额查询响应主体
    /// </summary>
    public class V1_CMHISBLNCTRNRS : IResponse
    {
        /// <summary>
        /// 历史留存金额查询响应主体
        /// </summary>
        public CMHISBLNCTRNRS CMHISBLNCTRNRS { get; set; }
    }
    /// <summary>
    /// 历史留存金额查询响应主体
    /// </summary>
    public class CMHISBLNCTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 历史留存金额查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CMHISBLNCTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 历史留存金额查询响应内容
    /// </summary>
    public class CMHISBLNCTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 结算中心账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT FUNDACCT { get; set; }
        /// <summary>
        /// 历史留存金额查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CMHISBLNCTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 历史留存金额查询响应明细
    /// </summary>
    public class CMHISBLNCTRN_CONTENT
    {
        /// <summary>
        /// 成员单位账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT MBRACCT { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        [XmlIgnore]
        public DateTime DTTRN { get; set; }
        /// <summary>
        /// 起始日期，必回，yyyy-MM-dd ,对应<see cref="DTTRN"/>
        /// </summary>
        [XmlElement("DTTRN", Order = 1)]
        public string DTTRNStr
        {
            get
            {
                return this.DTTRN.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, new string[] { "yyyy-MM-dd","yyyy-MM-dd HH:mm:ss", "yyyy-MM-ddTHH:mm:ss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTTRN = tmp;
                }
            }
        }
        /// <summary>
        /// 日归集金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal DAYUPAMT { get; set; }
        /// <summary>
        /// 日调拨金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal DAYDNAMT { get; set; }
        /// <summary>
        /// 年归集金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal YEARUPAMT { get; set; }
        /// <summary>
        /// 年调拨金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal YEARDNAMT { get; set; }
        /// <summary>
        /// 历史留存金额（贡献度），decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal CONTRBTRATE { get; set; }
    }
}
