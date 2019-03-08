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
    /// 3.19.13跨境资金池国内、国际主账户互转响应主体
    /// </summary>
    public class V1_CBCPMAINTRSFRTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.13跨境资金池国内、国际主账户互转响应主体
        /// </summary>
        public CBCPMAINTRSFRTRNRS CBCPMAINTRSFRTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.13跨境资金池国内、国际主账户互转响应主体
    /// </summary>
    public class CBCPMAINTRSFRTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.13跨境资金池国内、国际主账户互转响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMAINTRSFRTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.13跨境资金池国内、国际主账户互转响应内容
    /// </summary>
    public class CBCPMAINTRSFRTRN_RSBODY
    {
        /// <summary>
        /// 交易类型 必回
        /// 1-外债本金借入
        /// 2-外债本息偿还
        /// 3-对外放款本金
        /// 4-对外放款本息收回
        /// </summary>
        [XmlElement(Order = 0)]
        public int TRADETYPE { get; set; }
        /// <summary>
        /// 货币种类，2位数字	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 划出账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string FROMACCTNO { get; set; }
        /// <summary>
        /// 划出账户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string FROMACCTNAME { get; set; }
        /// <summary>
        /// 划出账户属性 0- 国内主账号  1- 国际主账号 必回
        /// </summary>
        [XmlElement(Order = 4)]
        public int FROMACCTTYPE { get; set; }
        /// <summary>
        /// 划入账户名称	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string TOACCTNAME { get; set; }
        /// <summary>
        /// 划入账户属性 0- 国内主账号  1- 国际主账号 必回
        /// </summary>
        [XmlElement(Order = 6)]
        public int TOACCTTYPE { get; set; }
        /// <summary>
        /// 金额，Decimal(17,2)	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 批件号	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string APPROVEDDOCNO { get; set; }
        /// <summary>
        /// 美元折算率	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal EXCHNGRATE { get; set; }
        /// <summary>
        /// 债务人名称	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string DEBTORNAME { get; set; }
        /// <summary>
        /// 债务人国别，3位	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string DEBTORCOUNTRYCODE { get; set; }
        /// <summary>
        /// 债权人名称	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string CREDITORNAME { get; set; }
        /// <summary>
        /// 债权人国别，3位	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public string CREDITORCOUNTRYCODE { get; set; }
        /// <summary>
        /// 偿还本金金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal? REPAYPRINCIPAL { get; set; }
        /// <summary>
        /// 偿还利息金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal? REPAYINTEREST { get; set; }
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
        /// 收回本金金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? RECOVERPRINCIPAL { get; set; }
        /// <summary>
        /// 收回利息金额(原币)	非必回
        /// </summary>
        [XmlElement(Order = 19)]
        public decimal? RECOVERINTEREST { get; set; }
        /// <summary>
        /// 收回本金金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 20)]
        public decimal? RECOVERPRINCIPALUSD { get; set; }
        /// <summary>
        /// 收回利息金额(美元)	非必回
        /// </summary>
        [XmlElement(Order = 21)]
        public decimal? RECOVERINTERESTUSD { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD。目前只支持当日, 对应<see cref="DTDUE"/>	必回
        /// </summary>
        [XmlElement("DTDUE", Order = 22)]
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
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 23)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
