using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.1证券资金清算汇划响应主体
    /// </summary>
    public class V1_STOCKTRSFRTRNRS : IResponse
    {
        /// <summary>
        /// 3.5.1证券资金清算汇划响应主体
        /// </summary>
        public STOCKTRSFRTRNRS STOCKTRSFRTRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.1证券资金清算汇划响应主体
    /// </summary>
    public class STOCKTRSFRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.1证券资金清算汇划响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public STOCKTRSFRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.1证券资金清算汇划响应内容
    /// </summary>
    public class STOCKTRSFRTRN_RSBODY
    {
        /// <summary>
        /// 付款人账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT ACCTFROM { get; set; }
        /// <summary>
        /// 收款人账户信息
        /// </summary>
        [XmlElement(Order = 1)]
        public Requests.RQACCT ACCTTO { get; set; }
        /// <summary>
        /// 证券账户代号, 最大20位；上海分公司网下发行专户时证券账户代号必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string SECRACCTID { get; set; }
        /// <summary>
        /// 证券代码（沪市）, 最大20位；上海分公司网下发行专户时必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string STOCKCODE { get; set; }
        /// <summary>
        /// 资金账户代号（沪市）, 最大20位；上海分公司备付金时资金账户代号必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string FUNDACCTID { get; set; }
        /// <summary>
        /// 网下发行摘要信息（深市）, 最大20位；深圳分公司网下发行专户时必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string SUMM { get; set; }
        /// <summary>
        /// 深市席位号（深市）, 最大20位；深圳备付金时必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string SEATNO { get; set; }
        /// <summary>
        /// 交易金额，金额>0,整数位最大15位，小数位2位
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 备注，仅在在付款方对账单中出现，最大50
        /// </summary>
        [XmlElement(Order = 8)]
        public string MEMO { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
