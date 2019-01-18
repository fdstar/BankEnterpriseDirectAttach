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
    /// 集团业务内部往来查询响应主体
    /// </summary>
    public class V1_CMINNERQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 集团业务内部往来查询响应主体
        /// </summary>
        public CMINNERQUERYTRNRS CMINNERQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 集团业务内部往来查询响应主体
    /// </summary>
    public class CMINNERQUERYTRNRS:BIZRSBASE
    {
        /// <summary>
        /// 集团业务内部往来查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CMINNERQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 集团业务内部往来查询响应内容
    /// </summary>
    public class CMINNERQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 集团业务内部往来查询响应集合
        /// </summary>
        [XmlElement("CONTENT")]
        public List<CMINNERQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 集团业务内部往来查询响应明细
    /// </summary>
    public class CMINNERQUERYTRN_CONTENT
    {
        /// <summary>
        /// 结算中心信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户代号
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCT MBRACCT { get; set; }
        /// <summary>
        /// 成员单位登记日期YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DTREG { get; set; }
        /// <summary>
        /// 服务端日期时间，yyyy-MM-dd HH:mm:ss ,对应<see cref="DTREG"/>
        /// </summary>
        [XmlElement("DTREG", Order = 2)]
        public string DTACCTStr
        {
            get
            {
                return this.DTREG.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTREG = tmp;
                }
            }
        }
        /// <summary>
        /// 年归集累计，decimal(17,2)，即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal YEARSUMUP { get; set; }
        /// <summary>
        /// 年下拨累计，decimal(17,2)，即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal YEARSUMDOWN { get; set; }
        /// <summary>
        /// 归集减去下拨，decimal(17,2)，即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal SUM { get; set; }
    }
}
