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
    /// 3.5.1证券资金清算汇划请求主体
    /// </summary>
    public class V1_STOCKTRSFRTRNRQ : IRequest<V1_STOCKTRSFRTRNRS>
    {
        /// <summary>
        /// 3.5.1证券资金清算汇划请求主体
        /// </summary>
        public STOCKTRSFRTRNRQ STOCKTRSFRTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.1证券资金清算汇划请求主体
    /// </summary>
    public class STOCKTRSFRTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.1证券资金清算汇划请求内容
        /// 注意以下四项属性同一时间只能输入一个
        /// <see cref="STOCKTRSFRTRN_RQBODY.SEATNO"/>、<see cref="STOCKTRSFRTRN_RQBODY.SUMM"/>
        /// <see cref="STOCKTRSFRTRN_RQBODY.FUNDACCTID"/>、<see cref="STOCKTRSFRTRN_RQBODY.HSCOND"/>
        /// </summary>
        [XmlElement(Order = 1)]
        public STOCKTRSFRTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.1证券资金清算汇划请求内容
    /// </summary>
    public class STOCKTRSFRTRN_RQBODY
    {
        /// <summary>
        /// 付款人账户信息	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT ACCTFROM { get; set; }
        /// <summary>
        /// 收款人账户信息	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT ACCTTO { get; set; }
        /// <summary>
        /// 交易金额，金额>0,整数位最大15位，小数位2位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 中国证券登记结算有限责任公司深圳分公司(备付金)：337010172600002848 
        /// 券商席位号（深市网上）, 最大20位；深圳备付金时必填	4选1 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string SEATNO { get; set; }
        /// <summary>
        /// 中国证券登记结算有限责任公司深圳分公司网下发行专户：337010100100219872
        /// 网下发行摘要信息（深市）, 最大20位；深圳分公司网下发行专户时必填	4选1 必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string SUMM { get; set; }
        /// <summary>
        /// 中国证券登记结算有限责任公司上海分公司(备付金)：216200143300010514
        /// 资金账户代号（沪市网上）, 最大20位；上海分公司备付金时资金账户代号必填	4选1 必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string FUNDACCTID { get; set; }
        /// <summary>
        /// 中国证券登记结算有限责任公司上海分公司(网下发行专户)：216200100100239302
        /// 资金账户代号  4选1 必输
        /// </summary>
        [XmlElement(Order = 6)]
        public HSCOND HSCOND { get; set; }
        /// <summary>
        /// 备注，仅在付款方对账单中出现，最大50	非必输
        /// </summary>
        [XmlElement(Order = 99)]
        public string MEMO { get; set; }
    }
    /// <summary>
    /// 3.5.1	证券资金清算汇划 资金账户代号，对应 中国证券登记结算有限责任公司上海分公司(网下发行专户)：216200100100239302
    /// </summary>
    public class HSCOND
    {
        /// <summary>
        /// 证券账户代号（网下申购），最大20位；上海分公司网下发行专户时证券账户代号必填。	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 证券代码（网下申购）, 最大20位；上海分公司网下发行专户时必填。	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string STOCKCODE { get; set; }
    }
}
