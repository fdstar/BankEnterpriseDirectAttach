using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.19.4跨境资金池集中结汇请求主体
    /// </summary>
    public class V1_CBCPEXCHNGTRNRQ : IRequest<V1_CBCPEXCHNGTRNRS>
    {
        /// <summary>
        /// 3.19.4跨境资金池集中结汇请求主体
        /// </summary>
        public CBCPEXCHNGTRNRQ CBCPEXCHNGTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.4跨境资金池集中结汇请求主体
    /// </summary>
    public class CBCPEXCHNGTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.4跨境资金池集中结汇请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPEXCHNGTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.4跨境资金池集中结汇请求内容
    /// </summary>
    public class CBCPEXCHNGTRN_RQBODY
    {
        /// <summary>
        /// 成员外币账号，18位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员外币账户名称	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 人民币账号	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string RMBACCTNO { get; set; }
        /// <summary>
        /// 人民币账户名称	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string RMBACCTNAME { get; set; }
        /// <summary>
        /// 货币符号 参考附件“货币种类编码”中的货币种类编码 非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 外币金额，Decimal(17,2)	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 结汇类别 必输
        /// 0-贸易项下结汇   
        /// 1-非贸易项下结汇
        /// 2-资本项下结汇
        /// </summary>
        [XmlElement(Order = 7)]
        public int EXCHNGTYPE { get; set; }
        /// <summary>
        /// 结汇代码 参考附件“结售汇编码”中的“结售汇编码－结汇”	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string EXCHNGCODE { get; set; }
        /// <summary>
        /// 外汇账户交易编码 参考附件“外汇账户交易编码（收入）” 	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string TRANSNO { get; set; }
        /// <summary>
        /// 备注，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string MEMO { get; set; }
    }
}
