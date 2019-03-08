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
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应主体
    /// </summary>
    public class V1_CBCPMAINTRADEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应主体
        /// </summary>
        public CBCPMAINTRADEQUERYTRNRS CBCPMAINTRADEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应主体
    /// </summary>
    public class CBCPMAINTRADEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMAINTRADEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应内容
    /// </summary>
    public class CBCPMAINTRADEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应集合 外债明细项
        /// 当查询类型为“1：外债明细台账”是返回此节点，不返回 CONTENT_FKMX 节点
        /// </summary>
        [XmlElement("CONTENT_WZMX", Order = 1)]
        public List<CBCPMAINTRADEQUERYTRN_CONTENT_WZMX> WZMXList { get; set; }
        /// <summary>
        /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应集合 放款明细项
        /// 当查询类型为“2：对外放款明细台账”时，返回此节点，不返回 CONTENT_WZMX 节点
        /// </summary>
        [XmlElement("CONTENT_FKMX", Order = 2)]
        public List<CBCPMAINTRADEQUERYTRN_CONTENT_FKMX> FKMXList { get; set; }
    }
    /// <summary>
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应明细 外债明细项
    /// </summary>
    public class CBCPMAINTRADEQUERYTRN_CONTENT_WZMX
    {
        /// <summary>
        /// 交易类型 必回
        /// 1：外债本金借入
        /// 2：外债本息偿还
        /// </summary>
        [XmlElement(Order = 0)]
        public int TRADETYPE { get; set; }
        /// <summary>
        /// 网点号,5位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 划入账号，国内主账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string TOACCTNO { get; set; }
        /// <summary>
        /// 划入账户名称，借款人	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string TOACCTNAME { get; set; }
        /// <summary>
        /// 货币种类，2位数字	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 批件号	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string APPROVEDDOCNO { get; set; }
        /// <summary>
        /// 债权人名称	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string CREDITORNAME { get; set; }
        /// <summary>
        /// 债权人国别，3位	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string CREDITORCOUNTRYCODE { get; set; }
        /// <summary>
        /// 美元折算率	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal EXCHNGRATE { get; set; }
        /// <summary>
        /// 未偿还本金余额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? UNREPAYPRINCIPAL { get; set; }
        /// <summary>
        /// 偿还本金金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? REPAYPRINCIPAL { get; set; }
        /// <summary>
        /// 偿还利息金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal? REPAYINTEREST { get; set; }
        /// <summary>
        /// 累计偿还本金金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal? TOTALREPAYPRINCIPAL { get; set; }
        /// <summary>
        /// 累计偿还利息金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal? TOTALREPAYINTEREST { get; set; }
        /// <summary>
        /// 未偿还本金余额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal? UNREPAYPRINCIPALUSD { get; set; }
        /// <summary>
        /// 偿还本金金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 16)]
        public decimal? REPAYPRINCIPALUSD { get; set; }
        /// <summary>
        /// 偿还利息金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal? REPAYINTERESTUSD { get; set; }
        /// <summary>
        /// 累计偿还本金金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? TOTALREPAYPRINCIPALUSD { get; set; }
        /// <summary>
        /// 累计偿还利息金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 19)]
        public decimal? TOTALREPAYINTERESTUSD { get; set; }
        /// <summary>
        /// 结清状态 必回
        /// 0：未结清
        /// 1：已结清
        /// </summary>
        [XmlElement(Order = 20)]
        public int SETTLESTATUS { get; set; }
        /// <summary>
        /// 交易时间，yyyy-MM-dd HH:mm:ss	必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRADEDATETIME { get; set; }
        /// <summary>
        /// 交易时间，yyyy-MM-dd HH:mm:ss, 对应<see cref="TRADEDATETIME"/>	必输 
        /// </summary>
        [XmlElement("TRADEDATETIME", Order = 21)]
        public string TRADEDATETIMEStr
        {
            get
            {
                return this.TRADEDATETIME.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRADEDATETIME = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 3.19.14跨境资金池国内、国际主账户互转交易查询响应明细 放款明细项
    /// </summary>
    public class CBCPMAINTRADEQUERYTRN_CONTENT_FKMX
    {
        /// <summary>
        /// 交易类型 必回
        /// 3：对外放款本金
        /// 4：对外放款本息收回
        /// </summary>
        [XmlElement(Order = 0)]
        public int TRADETYPE { get; set; }
        /// <summary>
        /// 网点号,5位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 划出账号，国内主账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string FROMACCTNO { get; set; }
        /// <summary>
        /// 划出账户名称，放款人	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string FROMACCTNAME { get; set; }
        /// <summary>
        /// 货币种类，2位数字	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 批件号	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string APPROVEDDOCNO { get; set; }
        /// <summary>
        /// 债务人名称	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string DEBTORNAME { get; set; }
        /// <summary>
        /// 债务人国别，3位	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string DEBTORCOUNTRYCODE { get; set; }
        /// <summary>
        /// 美元折算率	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal EXCHNGRATE { get; set; }
        /// <summary>
        /// 未收回本金余额(原币)，可流出净额	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? UNRECOVERPRINCIPAL { get; set; }
        /// <summary>
        /// 收回本金金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? RECOVERPRINCIPAL { get; set; }
        /// <summary>
        /// 收回利息金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal? RECOVERINTEREST { get; set; }
        /// <summary>
        /// 累计收回本金金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal? TOTALRECOVERPRINCIPAL { get; set; }
        /// <summary>
        /// 累计收回利息金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal? TOTALRECOVERINTEREST { get; set; }
        /// <summary>
        /// 未收回本金余额(美元)，可流出净额	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal? UNRECOVERPRINCIPALUSD { get; set; }
        /// <summary>
        /// 收回本金金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 16)]
        public decimal? RECOVERRINCIPALUSD { get; set; }
        /// <summary>
        /// 收回利息金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal? RECOVERINTERESTUSD { get; set; }
        /// <summary>
        /// 累计收回本金金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? TOTALRECOVERPRINCIPALUSD { get; set; }
        /// <summary>
        /// 累计收回利息金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 19)]
        public decimal? TOTALRECOVERINTERESTUSD { get; set; }
        /// <summary>
        /// 结清状态 必回
        /// 0：未结清
        /// 1：已结清
        /// </summary>
        [XmlElement(Order = 20)]
        public int SETTLESTATUS { get; set; }
        /// <summary>
        /// 交易时间，yyyy-MM-dd HH:mm:ss	必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRADEDATETIME { get; set; }
        /// <summary>
        /// 交易时间，yyyy-MM-dd HH:mm:ss, 对应<see cref="TRADEDATETIME"/>	必输 
        /// </summary>
        [XmlElement("TRADEDATETIME", Order = 21)]
        public string TRADEDATETIMEStr
        {
            get
            {
                return this.TRADEDATETIME.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRADEDATETIME = tmp;
                }
            }
        }
    }
}
