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
    /// 3.5.12期权现货交易明细查询响应主体
    /// </summary>
    public class V1_OPTIONSPOTDETAILTRNRS : IResponse
    {
        /// <summary>
        /// 3.5.12期权现货交易明细查询响应主体
        /// </summary>
        public OPTIONSPOTDETAILTRNRS OPTIONSPOTDETAILTRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.12期权现货交易明细查询响应主体
    /// </summary>
    public class OPTIONSPOTDETAILTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.12期权现货交易明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public OPTIONSPOTDETAILTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.12期权现货交易明细查询响应内容
    /// </summary>
    public class OPTIONSPOTDETAILTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.5.12期权现货交易明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<OPTIONSPOTDETAILTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.5.12期权现货交易明细查询响应明细
    /// </summary>
    public class OPTIONSPOTDETAILTRN_CONTENT
    {
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string BUSSNAME { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        [XmlElement(Order = 2)]
        public string TRACEDATE { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement(Order = 3)]
        public string TRACETIME { get; set; }
        /// <summary>
        /// 交易时间，如果获取失败则返回null
        /// </summary>
        [XmlIgnore]
        public DateTime? TransactionTime
        {
            get
            {
                if (DateTime.TryParseExact(TRACEDATE + TRACETIME, new string[] { "yyyy-MM-dd", "yyyy-MM-ddHH:mm:ss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime time))
                {
                    return time;
                }
                return null;
            }
            set
            {
                this.TRACEDATE = value?.ToString("yyyy-MM-dd");
                this.TRACETIME = value?.ToString("HH:mm:ss");
            }
        }
        /// <summary>
        /// 币种，2位
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 资金账户
        /// </summary>
        [XmlElement(Order = 5)]
        public string FUNDACCTNO { get; set; }
        /// <summary>
        /// 期货代码
        /// </summary>
        [XmlElement(Order = 6)]
        public string FUNDBRANCHNO { get; set; }
        /// <summary>
        /// 转账金额
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal TRANSFERAMT { get; set; }
        /// <summary>
        /// 资金状态
        /// </summary>
        [XmlElement(Order = 8)]
        public string FUNDSTATUS { get; set; }
    }
}
