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
    /// 3.19.5跨境资金池集中结汇交易明细查询响应主体
    /// </summary>
    public class V1_CBCPEXCHNGTRADEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.5跨境资金池集中结汇交易明细查询响应主体
        /// </summary>
        public CBCPEXCHNGTRADEQUERYTRNRS CBCPEXCHNGTRADEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.5跨境资金池集中结汇交易明细查询响应主体
    /// </summary>
    public class CBCPEXCHNGTRADEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.5跨境资金池集中结汇交易明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPEXCHNGTRADEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.5跨境资金池集中结汇交易明细查询响应内容
    /// </summary>
    public class CBCPEXCHNGTRADEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.19.5跨境资金池集中结汇交易明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CBCPEXCHNGTRADEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.19.5跨境资金池集中结汇交易明细查询响应明细
    /// </summary>
    public class CBCPEXCHNGTRADEQUERYTRN_CONTENT
    {
        /// <summary>
        /// 凭证号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 成员外币账号，18位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员外币账户名称	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 人民币账号	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string RMBACCTNO { get; set; }
        /// <summary>
        /// 人民币账户名称	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string RMBACCTNAME { get; set; }
        /// <summary>
        /// 外币金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 人民币金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal RMBAMOUNT { get; set; }
        /// <summary>
        /// 结汇汇率	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal EXCHNGRATE { get; set; }
        /// <summary>
        /// 利率浮动方式 0-按浮动值浮动，1-按百分比浮动 非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public int? FLOWTYPE { get; set; }
        /// <summary>
        /// 浮动值	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal FLOWVALUE { get; set; }
        /// <summary>
        /// 结汇类别 必回
        /// 0-贸易项下结汇   
        /// 1-非贸易项下结汇
        /// 2-资本项下结汇
        /// </summary>
        [XmlElement(Order = 10)]
        public int EXCHNGTYPE { get; set; }
        /// <summary>
        /// 结汇代码 参考附件“结售汇编码”中的“结售汇编码－结汇”	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string EXCHNGCODE { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD	必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRADEDATE { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD, 对应<see cref="TRADEDATE"/>	必回 
        /// </summary>
        [XmlElement("TRADEDATE", Order = 12)]
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
        /// 交易状态 0-交易成功 1-交易失败 必回
        /// </summary>
        [XmlElement(Order = 13)]
        public int TRADESTATUS { get; set; }
    }
}
