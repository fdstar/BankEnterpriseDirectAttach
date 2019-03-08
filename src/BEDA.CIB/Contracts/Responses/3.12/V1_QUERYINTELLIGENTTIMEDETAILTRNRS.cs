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
    /// 3.12.7.7定活互转智能定期存款—明细查询响应主体
    /// </summary>
    public class V1_QUERYINTELLIGENTTIMEDETAILTRNRS : IResponse
    {
        /// <summary>
        /// 3.12.7.7定活互转智能定期存款—明细查询响应主体
        /// </summary>
        public QUERYINTELLIGENTTIMEDETAILTRNRS QUERYINTELLIGENTTIMEDETAILTRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.7.7定活互转智能定期存款—明细查询响应主体
    /// </summary>
    public class QUERYINTELLIGENTTIMEDETAILTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.7.7定活互转智能定期存款—明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QUERYINTELLIGENTTIMEDETAILTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.7定活互转智能定期存款—明细查询响应内容
    /// </summary>
    public class QUERYINTELLIGENTTIMEDETAILTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 客户代号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string NCID { get; set; }
        /// <summary>
        /// 相关活期账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string DEMANDACCOUNTNAME { get; set; }
        /// <summary>
        /// 关联智能定期存款账号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 3.12.7.7定活互转智能定期存款—明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<QUERYINTELLIGENTTIMEDETAILTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.12.7.7定活互转智能定期存款—明细查询响应明细
    /// </summary>
    public class QUERYINTELLIGENTTIMEDETAILTRN_CONTENT
    {
        /// <summary>
        /// 交易日期	必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRADEDATE { get; set; }
        /// <summary>
        /// 交易日期 ,对应<see cref="TRADEDATE"/> 必回
        /// </summary>
        [XmlElement("TRADEDATE", Order = 2)]
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
        /// 交易金额	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 交易类型	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string CASHFLAG { get; set; }
        /// <summary>
        /// 摘要名称	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string SUMMARYCODE { get; set; }
        /// <summary>
        /// 账户余额	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal BALANCE { get; set; }
    }
}
