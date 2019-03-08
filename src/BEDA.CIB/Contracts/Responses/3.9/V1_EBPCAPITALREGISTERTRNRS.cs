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
    /// 3.9.3.18电子商业汇票资产业务登记薄响应主体
    /// </summary>
    public class V1_EBPCAPITALREGISTERTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.18电子商业汇票资产业务登记薄响应主体
        /// </summary>
        public EBPCAPITALREGISTERTRNRS EBPCAPITALREGISTERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.18电子商业汇票资产业务登记薄响应主体
    /// </summary>
    public class EBPCAPITALREGISTERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.18电子商业汇票资产业务登记薄响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCAPITALREGISTERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.18电子商业汇票资产业务登记薄响应内容
    /// </summary>
    public class EBPCAPITALREGISTERTRN_RSBODY
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
        /// 3.9.3.18电子商业汇票资产业务登记薄响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPCAPITALREGISTERTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.18电子商业汇票资产业务登记薄响应内容
    /// </summary>
    public class EBPCAPITALREGISTERTRN_CONTENT
    {
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 业务类型 必回
        /// 01-流动资金贷款
        /// 02-国内信用证 
        /// 03-法人账户透支
        /// 04-融资性保函
        /// 05-非融资性保函
        /// </summary>
        [XmlElement(Order = 4)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRADEDATE { get; set; }
        /// <summary>
        /// 交易日期，格式yyyy-MM-dd ,对应<see cref="TRADEDATE"/> 必回
        /// </summary>
        [XmlElement("TRADEDATE", Order = 5)]
        public string TRADEDATEStr
        {
            get
            {
                return this.TRADEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRADEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额（18,2）	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal TRADEAMT { get; set; }
        /// <summary>
        /// 业务状态，01已生效 02已结清	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string BIZSTATUS { get; set; }
        /// <summary>
        /// 归属机构号	必回
        /// </summary>
        [XmlElement(Order = 25)]
        public string BELONGORGNO { get; set; }
        /// <summary>
        /// 归属机构名称	必回
        /// </summary>
        [XmlElement(Order = 26)]
        public string BELONGORGNAME { get; set; }
        /// <summary>
        /// 申请备注	非必回
        /// </summary>
        [XmlElement(Order = 27)]
        public string MEMO { get; set; }
    }
}
