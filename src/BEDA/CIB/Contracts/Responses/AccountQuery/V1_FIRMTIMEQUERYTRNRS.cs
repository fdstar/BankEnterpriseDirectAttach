using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 单位定期一本通账户查询响应主体
    /// </summary>
    public class V1_FIRMTIMEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 单位定期一本通账户查询响应
        /// </summary>
        public FIRMTIMEQUERYTRNRS FIRMTIMEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 单位定期一本通账户查询响应
    /// </summary>
    public class FIRMTIMEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 非定期存款账户信息，必回
        /// </summary>
        [XmlElement(Order = 2)]
        public FIRMTIMERSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 单位定期一本通账户查询结果集合
    /// </summary>
    public class FIRMTIMERSBODY
    {
        /// <summary>
        /// 是否还有下一页：Y－有,N－否
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 定期一本通总账号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 累计金额，2位小数
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal SUMAMT { get; set; }
        /// <summary>
        /// 查询结果集合
        /// </summary>
        [XmlElement("CONTENT", Order = 3)]
        public List<FIRMTIMECONTENT> List { get; set; }
    }
    /// <summary>
    /// 单位定期一本通账户查询结果明细
    /// </summary>
    public class FIRMTIMECONTENT
    {
        /// <summary>
        /// 账号序号，最长6位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNUM { get; set; }
        /// <summary>
        /// 账户余额，2位小数
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 定期账户状态
        /// </summary>
        [XmlElement(Order = 2)]
        public string STATUS { get; set; }
        /// <summary>
        /// 起息日期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement(Order = 3)]
        public string DTSTART { get; set; }
        /// <summary>
        /// 到期日期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement(Order = 4)]
        public string DTEND { get; set; }
        /// <summary>
        /// 存期
        /// </summary>
        [XmlElement(Order = 5)]
        public string TERM { get; set; }
        /// <summary>
        /// 续存标志
        /// </summary>
        [XmlElement(Order = 6)]
        public string CONTFLAG { get; set; }
        /// <summary>
        /// 续存存期
        /// </summary>
        [XmlElement(Order = 7)]
        public string TERMTYPE { get; set; }
        /// <summary>
        /// 销户日期，格式yyyy-MM-dd
        /// </summary>
        [XmlElement(Order = 8)]
        public string CANCALDATE { get; set; }
    }
}
