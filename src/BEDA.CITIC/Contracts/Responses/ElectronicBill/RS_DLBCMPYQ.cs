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
    /// 支付信用信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMPYQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<PaymentCredit> List { get; set; }
    }
    /// <summary>
    /// 支付信用
    /// </summary>
    public class PaymentCredit
    {
        /// <summary>
        /// 客户名称 varchar(122)
        /// </summary>
        [XmlElement("CUSTNAM")]
        public string CUSTNAM { get; set; }
        /// <summary>
        /// 客户组织机构代码 char(20)
        /// </summary>
        [XmlElement("CUSTCOD")]
        public string CUSTCOD { get; set; }
        /// <summary>
        /// 承兑总笔数 char(3)
        /// </summary>
        [XmlElement("ACCPSUM")]
        public int ACCPSUM { get; set; }
        /// <summary>
        /// 承兑总金额 decimal(15，2)
        /// </summary>
        [XmlElement("ACCPAMT")]
        public decimal ACCPAMT { get; set; }
        /// <summary>
        /// 已结清总笔数 char(3)
        /// </summary>
        [XmlElement("CLRSUM")]
        public int CLRSUM { get; set; }
        /// <summary>
        /// 已结清总金额 decimal(15，2)
        /// </summary>
        [XmlElement("CLRAMT")]
        public decimal CLRAMT { get; set; }
        /// <summary>
        /// 未结清总笔数 char(3)
        /// </summary>
        [XmlElement("UCLRSUM")]
        public int UCLRSUM { get; set; }
        /// <summary>
        /// 未结清总金额 decimal(15，2)
        /// </summary>
        [XmlElement("UCLRAMT")]
        public decimal UCLRAMT { get; set; }
        /// <summary>
        /// 拒付总笔数 char(3)
        /// </summary>
        [XmlElement("RNONPSUM")]
        public int RNONPSUM { get; set; }
        /// <summary>
        /// 拒付总金额 decimal(15，2)
        /// </summary>
        [XmlElement("NONPAMT")]
        public decimal NONPAMT { get; set; }
        /// <summary>
        /// 今年拒付总笔数 char(3)
        /// </summary>
        [XmlElement("TYNPSUM")]
        public int TYNPSUM { get; set; }
        /// <summary>
        /// 今年拒付总金额 decimal(15，2)
        /// </summary>
        [XmlElement("TYNPAMT")]
        public decimal TYNPAMT { get; set; }
        /// <summary>
        /// 去年拒付总笔数 char(3)
        /// </summary>
        [XmlElement("LYNPSUM")]
        public int LYNPSUM { get; set; }
        /// <summary>
        /// 去年拒付总金额 decimal(15，2)
        /// </summary>
        [XmlElement("LYNPAMT")]
        public decimal LYNPAMT { get; set; }
    }
}