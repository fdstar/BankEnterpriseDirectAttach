using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.11跨境资金池账户资金池属性查询响应主体
    /// </summary>
    public class V1_CBCPACCTCFGQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.11跨境资金池账户资金池属性查询响应主体
        /// </summary>
        public CBCPACCTCFGQUERYTRNRS CBCPACCTCFGQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.11跨境资金池账户资金池属性查询响应主体
    /// </summary>
    public class CBCPACCTCFGQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.11跨境资金池账户资金池属性查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPACCTCFGQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.11跨境资金池账户资金池属性查询响应内容
    /// </summary>
    public class CBCPACCTCFGQUERYTRN_RSBODY
    {
        /// <summary>
        /// 成员活期账户代号 18位	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员活期账户名称，60位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 主账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 主账户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string MAINACCTNAME { get; set; }
        /// <summary>
        /// 成员序号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string SEQNO { get; set; }
        /// <summary>
        /// 币种	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 资金性质  必回
        /// 2-经常项目
        /// 3-资本项目
        /// 4-NRA项目
        /// 5-无实体账号账户(指的是无实体账户的国际成员账户)
        /// </summary>
        [XmlElement(Order = 6)]
        public int ACCTTYPE { get; set; }
        /// <summary>
        /// 归集类型 0-不归集 1-定时固定余额归集 2-定时余额按比例归集 必回
        /// </summary>
        [XmlElement(Order = 7)]
        public int SUMUPTYPE { get; set; }
        /// <summary>
        /// 自动归集频率 非必回
        /// 0-每天，
        /// 1-每周，
        /// 2-每旬，
        /// 3-每月
        /// </summary>
        [XmlElement(Order = 8)]
        public int? AUTOSUMUPFREQ { get; set; }
        /// <summary>
        /// 自动归集周期	非必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string AUTOSUMUPCYCLE { get; set; }
        /// <summary>
        /// 自动归集时点	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string AUTOSUMUPTIME { get; set; }
        /// <summary>
        /// 归集留存金额	非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? RETAINAMOUNT1 { get; set; }
        /// <summary>
        /// 归集比例	非必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal? SUMUPRATIO { get; set; }
        /// <summary>
        /// 最低归集下拨金额	非必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal? MINALLOCAMOUNT { get; set; }
        /// <summary>
        /// 下拨类型 0-不下拨，1-定时固定余额下拨 必回
        /// </summary>
        [XmlElement(Order = 14)]
        public int ALLOCTYPE { get; set; }
        /// <summary>
        /// 自动下拨频率 非必回
        /// 0-每天，
        /// 1-每周，
        /// 2-每旬，
        /// 3-每月
        /// </summary>
        [XmlElement(Order = 15)]
        public int? AUTOALLOCFREQ { get; set; }
        /// <summary>
        /// 自动下拨周期	非必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string AUTOALLOCCYCLE { get; set; }
        /// <summary>
        /// 自动下拨时点，整点	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public string AUTOALLOCTIME { get; set; }
        /// <summary>
        /// 下拨留存金额	非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? RETAINAMOUNT2 { get; set; }
        /// <summary>
        /// 透支标志 0-不透支，1-透支 必回
        /// </summary>
        [XmlElement(Order = 19)]
        public int OVERDRAFT { get; set; }
        /// <summary>
        /// 透支额度	非必回
        /// </summary>
        [XmlElement(Order = 20)]
        public decimal? MAXOVERAMOUNT { get; set; }
        /// <summary>
        /// 透支利率	非必回
        /// </summary>
        [XmlElement(Order = 21)]
        public decimal? OVERINTEREST { get; set; }
        /// <summary>
        /// 是否计息（内部计息标志） 0-计息，1-不计息 必回
        /// </summary>
        [XmlElement(Order = 22)]
        public int INTRSTFLAG { get; set; }
        /// <summary>
        /// 上存利率	非必回
        /// </summary>
        [XmlElement(Order = 23)]
        public decimal? SUMUPINTEREST { get; set; }
        /// <summary>
        /// 结息方式 0-自动，1-手动 必回
        /// </summary>
        [XmlElement(Order = 24)]
        public int SETTLETYPE { get; set; }
        /// <summary>
        /// 积数处理方式 0-积数清空不计息   1-积数清空计息   2-积数不清空不计息 必回
        /// </summary>
        [XmlElement(Order = 25)]
        public int INTEGRALHANDLETY { get; set; }
        /// <summary>
        /// 代理付汇 0-是，1-否 必回
        /// </summary>
        [XmlElement(Order = 26)]
        public int AGENPAY { get; set; }
        /// <summary>
        /// 代理结汇 0-是，1-否 必回
        /// </summary>
        [XmlElement(Order = 27)]
        public int AGENEXCHG { get; set; }
    }
}
