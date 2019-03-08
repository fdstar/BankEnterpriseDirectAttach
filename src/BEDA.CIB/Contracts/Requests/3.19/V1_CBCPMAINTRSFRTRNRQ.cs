using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.19.13跨境资金池国内、国际主账户互转请求主体
    /// </summary>
    public class V1_CBCPMAINTRSFRTRNRQ : IRequest<V1_CBCPMAINTRSFRTRNRS>
    {
        /// <summary>
        /// 3.19.13跨境资金池国内、国际主账户互转请求主体
        /// </summary>
        public CBCPMAINTRSFRTRNRQ CBCPMAINTRSFRTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.13跨境资金池国内、国际主账户互转请求主体
    /// </summary>
    public class CBCPMAINTRSFRTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.13跨境资金池国内、国际主账户互转请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMAINTRSFRTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.13跨境资金池国内、国际主账户互转请求内容
    /// </summary>
    public class CBCPMAINTRSFRTRN_RQBODY
    {
        /// <summary>
        /// 交易类型 必输
        /// 1-外债本金借入
        /// 2-外债本息偿还
        /// 3-对外放款本金
        /// 4-对外放款本息收回
        /// </summary>
        [XmlElement(Order = 2)]
        public int TRADETYPE { get; set; }
        /// <summary>
        /// 货币种类，2位数字	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2) 必输
        /// 当交易类型为：2-外债本金借入时：交易金额=偿还本金金额(原币)+偿还利息金额(原币)
        /// 4-对外放款本金时：交易金额=收回本金金额(原币)+收回利息金额(原币)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 批件号	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string APPROVEDDOCNO { get; set; }
        /// <summary>
        /// 债务人名称	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string DEBTORNAME { get; set; }
        /// <summary>
        /// 债务人国别，3位	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string DEBTORCOUNTRYCODE { get; set; }
        /// <summary>
        /// 债权人名称	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string CREDITORNAME { get; set; }
        /// <summary>
        /// 债权人国别，3位	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string CREDITORCOUNTRYCODE { get; set; }
        /// <summary>
        /// 偿还本金金额(原币)   非必输
        /// 当交易类型为：2-外债本息偿还 必输 
        /// </summary>
        [XmlIgnore]
        public decimal? REPAYPRINCIPAL { get; set; }
        /// <summary>
        /// 偿还本金金额(原币), 对应<see cref="REPAYPRINCIPAL"/>	非必输
        /// 当交易类型为：2-外债本息偿还 必输 
        /// </summary>
        [XmlElement("REPAYPRINCIPAL", Order = 10)]
        public string REPAYPRINCIPALStr
        {
            get
            {
                return this.REPAYPRINCIPAL?.ToString();
            }
            set
            {
                this.REPAYPRINCIPAL = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 偿还利息金额(原币)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? REPAYINTEREST { get; set; }
        /// <summary>
        /// 偿还利息金额(原币), 对应<see cref="REPAYINTEREST"/>	非必输
        /// </summary>
        [XmlElement("REPAYINTEREST", Order = 11)]
        public string REPAYINTERESTStr
        {
            get
            {
                return this.REPAYINTEREST?.ToString();
            }
            set
            {
                this.REPAYINTEREST = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 收回本金金额(原币) 非必输
        /// 当交易类型为：4-对外放款本息收回 必输
        /// </summary>
        [XmlIgnore]
        public decimal? RECOVERPRINCIPAL { get; set; }
        /// <summary>
        /// 收回本金金额(原币), 对应<see cref="RECOVERPRINCIPAL"/>	非必输
        /// 当交易类型为：4-对外放款本息收回 必输
        /// </summary>
        [XmlElement("RECOVERPRINCIPAL", Order = 12)]
        public string RECOVERPRINCIPALStr
        {
            get
            {
                return this.RECOVERPRINCIPAL?.ToString();
            }
            set
            {
                this.RECOVERPRINCIPAL = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 收回利息金额(原币)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? RECOVERINTEREST { get; set; }
        /// <summary>
        /// 收回利息金额(原币), 对应<see cref="RECOVERINTEREST"/>	非必输
        /// </summary>
        [XmlElement("RECOVERINTEREST", Order = 13)]
        public string RECOVERINTERESTStr
        {
            get
            {
                return this.RECOVERINTEREST?.ToString();
            }
            set
            {
                this.RECOVERINTEREST = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTDUE { get; set; } = DateTime.Now;
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日, 对应<see cref="DTDUE"/>	必输 
        /// </summary>
        [XmlElement("DTDUE", Order = 14)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTDUE = tmp;
                }
            }
        }
    }
}
