using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.4跨境资金池集中结汇响应主体
    /// </summary>
    public class V1_CBCPEXCHNGTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.4跨境资金池集中结汇响应主体
        /// </summary>
        public CBCPEXCHNGTRNRS CBCPEXCHNGTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.4跨境资金池集中结汇响应主体
    /// </summary>
    public class CBCPEXCHNGTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.4跨境资金池集中结汇响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPEXCHNGTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.4跨境资金池集中结汇响应内容
    /// </summary>
    public class CBCPEXCHNGTRN_RSBODY
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
        /// 货币符号 参考附件“货币种类编码”中的货币种类编码 必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 外币金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 人民币金额，Decimal(17,2)	非必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? RMBAMOUNT { get; set; }
        /// <summary>
        /// 结汇汇率	非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? EXCHNGRATE { get; set; }
        /// <summary>
        /// 结汇类别 必回
        /// 0-贸易项下结汇   
        /// 1-非贸易项下结汇
        /// 2-资本项下结汇
        /// </summary>
        [XmlElement(Order = 9)]
        public int EXCHNGTYPE { get; set; }
        /// <summary>
        /// 结汇代码 参考附件“结售汇编码”中的“结售汇编码－结汇”	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string EXCHNGCODE { get; set; }
        /// <summary>
        /// 外汇账户交易编码 参考附件“外汇账户交易编码（收入）” 	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string TRANSNO { get; set; }
        /// <summary>
        /// 备注，最大60位	非必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string MEMO { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
