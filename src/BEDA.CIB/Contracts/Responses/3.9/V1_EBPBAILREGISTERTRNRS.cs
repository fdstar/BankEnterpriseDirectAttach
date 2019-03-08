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
    /// 3.9.3.19电子商业汇票保证金交易登记薄响应主体
    /// </summary>
    public class V1_EBPBAILREGISTERTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.19电子商业汇票保证金交易登记薄响应主体
        /// </summary>
        public EBPBAILREGISTERTRNRS EBPBAILREGISTERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.19电子商业汇票保证金交易登记薄响应主体
    /// </summary>
    public class EBPBAILREGISTERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.19电子商业汇票保证金交易登记薄响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPBAILREGISTERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.19电子商业汇票保证金交易登记薄响应内容
    /// </summary>
    public class EBPBAILREGISTERTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 票据总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 本次查询总金额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 3.9.3.19电子商业汇票保证金交易登记薄响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPBAILREGISTERTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.19电子商业汇票保证金交易登记薄响应内容
    /// </summary>
    public class EBPBAILREGISTERTRN_CONTENT
    {
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 保证金账号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 转入账户	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string TOACCTNO { get; set; }
        /// <summary>
        /// 转入名称	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string TOACCTNAME { get; set; }
        /// <summary>
        /// 业务类型，01-提取 02-存入 必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 申请日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime APPLYDATE { get; set; }
        /// <summary>
        /// 申请日期，格式yyyy-MM-dd ,对应<see cref="APPLYDATE"/> 必回
        /// </summary>
        [XmlElement("APPLYDATE", Order = 8)]
        public string APPLYDATEStr
        {
            get
            {
                return this.APPLYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPLYDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal TRADEAMT { get; set; }
    }
}
