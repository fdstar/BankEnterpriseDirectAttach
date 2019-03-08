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
    /// 3.12.7.6定活互转智能定期存款账户查询响应主体
    /// </summary>
    public class V1_QUERYINTELLIGENTTIMETRNRS : IResponse
    {
        /// <summary>
        /// 3.12.7.6定活互转智能定期存款账户查询响应主体
        /// </summary>
        public QUERYINTELLIGENTTIMETRNRS QUERYINTELLIGENTTIMETRNRS { get; set; }
    }
    /// <summary>
    /// 3.12.7.6定活互转智能定期存款账户查询响应主体
    /// </summary>
    public class QUERYINTELLIGENTTIMETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.12.7.6定活互转智能定期存款账户查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QUERYINTELLIGENTTIMETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.6定活互转智能定期存款账户查询响应内容
    /// </summary>
    public class QUERYINTELLIGENTTIMETRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 客户代号	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string NCID { get; set; }
        /// <summary>
        /// 相关活期账号	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string DEMANDACCOUNTNO { get; set; }
        /// <summary>
        /// 客户号名称	非必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string DEMANDACCTNAME { get; set; }
        /// <summary>
        /// 币种	非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 3.12.7.6定活互转智能定期存款账户查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<QUERYINTELLIGENTTIMETRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.12.7.6定活互转智能定期存款账户查询响应明细
    /// </summary>
    public class QUERYINTELLIGENTTIMETRN_CONTENT
    {
        /// <summary>
        /// 签约账号(定期账号)	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 凭证代号	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string VOCHR_NO { get; set; }
        /// <summary>
        /// 开户金额	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal? OPEN_AMOUNT { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd 非必回
        /// </summary>
        [XmlIgnore]
        public DateTime? OPEN_DATE { get; set; }
        /// <summary>
        /// 开户日期，格式yyyy-MM-dd ,对应<see cref="OPEN_DATE"/> 非必回
        /// </summary>
        [XmlElement("OPEN_DATE", Order = 3)]
        public string OPEN_DATEStr
        {
            get
            {
                return this.OPEN_DATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.OPEN_DATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPEN_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日  （按协议） 非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string MATURITY_DATE { get; set; }
        /// <summary>
        /// 利率 （按协议）	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string INTRST_RATE { get; set; }
        /// <summary>
        /// 起息日期(期望日期)，格式yyyy-MM-dd 非必回
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSFR_DATE { get; set; }
        /// <summary>
        /// 起息日期(期望日期)，格式yyyy-MM-dd ,对应<see cref="TRSFR_DATE"/> 非必回
        /// </summary>
        [XmlElement("TRSFR_DATE", Order = 6)]
        public string TRSFR_DATEStr
        {
            get
            {
                return this.TRSFR_DATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.TRSFR_DATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSFR_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 账户可用余额	非必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? AVAIL_AMOUNT { get; set; }
        /// <summary>
        /// 账户状态 有效（2） 销户（0）	非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string STATUS { get; set; }
        /// <summary>
        /// 存期（按协议）	非必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string TERMTYPE { get; set; }
        /// <summary>
        /// 是否续存（不续存）	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string CONTINUETERM { get; set; }
    }
}
