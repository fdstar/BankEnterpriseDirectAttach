using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 信银国际外汇买卖（香港账户-集团客户）请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFXDTRN : RqBase<RS_DLFXDTRN>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFXDTRN"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 交易方式char(1), 1-即期外汇交易（SPOT）、2-远期外汇交易（FORWARD）、3-掉期外汇交易（SWAP）
        /// </summary>
        [XmlElement("tranType")]
        public int TranType { get; set; }
        /// <summary>
        /// 信银国际外汇交易号char(20),可空
        /// </summary>
        [XmlElement("ceiforexNo")]
        public string CeiforexNo { get; set; }
        /// <summary>
        /// 付款账号char(12),易方式为即期外汇交易和远期外汇交易时，必输；交易方式为掉期外汇交易时，送空
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 付款账号币种char(2), 交易方式为即期外汇交易和远期外汇交易时，必输；交易方式为掉期外汇交易时，送空; 数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD 
        /// </summary>
        [XmlElement("payCryType")]
        public string PayCryType { get; set; }
        /// <summary>
        /// 收款账号char(12)，交易方式为即期外汇交易和远期外汇交易时，必输；交易方式为掉期外汇交易时，送空
        /// </summary>
        [XmlElement("rcvAcc")]
        public string RcvAcc { get; set; }
        /// <summary>
        /// 收款账号币种char(2), 交易方式为即期外汇交易和远期外汇交易时，必输; 交易方式为掉期外汇交易时，送空; 数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD
        /// </summary>
        [XmlElement("rcvCryType")]
        public string RcvCryType { get; set; }
        /// <summary>
        /// 买入/卖出char(1), 交易方式为即期外汇交易和远期外汇交易时，必输；交易方式为掉期外汇交易时，送空; 数据字典：0-买入；1-卖出
        /// </summary>
        [XmlElement("businessType")]
        public string BusinessType { get; set; }
        /// <summary>
        /// 买入币种char(2), 交易方式为即期外汇交易和远期外汇交易，<see cref="BusinessType"/>标签为0-买入时必输，为1-卖出时选输; 交易方式为掉期外汇交易时，送空；数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD 、21-SEK、38-THB、93-ZAR
        /// </summary>
        [XmlElement("incryType")]
        public string IncryType { get; set; }
        /// <summary>
        /// 买入金额deciam(15,2）, 交易方式为即期外汇交易和远期外汇交易，<see cref="BusinessType"/>标签为0-买入时必输，为1-卖出时选输；交易方式为掉期外汇交易时，送空
        /// </summary>
        [XmlElement("buyAmt")]
        public decimal? BuyAmt { get; set; }
        /// <summary>
        /// 卖出币种char(2), 交易方式为即期外汇交易和远期外汇交易，<see cref="BusinessType"/>标签为1-卖出时必输，为0-买入时选输；交易方式为掉期外汇交易时，送空；数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD 、21-SEK、38-THB、93-ZAR
        /// </summary>
        [XmlElement("outcryType")]
        public string OutcryType { get; set; }
        /// <summary>
        /// 卖出金额deciam(15,2）, 交易方式为即期外汇交易和远期外汇交易，<see cref="BusinessType"/>标签为1-卖出时必输，为0-买入时选输；交易方式为掉期外汇交易时，送空
        /// </summary>
        [XmlElement("sellAmt")]
        public decimal? SellAmt { get; set; }
        /// <summary>
        /// 交易日期char(8)，必输
        /// </summary>
        [XmlIgnore]
        public DateTime TranDate { get; set; }
        /// <summary>
        /// 交易日期char(8)，必输, 对应<see cref="TranDate"/>
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDateStr
        {
            get
            {
                return this.TranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TranDate = tmp;
                }
            }
        }
        /// <summary>
        /// 交割日期char(8), 交易方式为即期外汇交易和远期外汇交易时，必输; 交易方式为掉期外汇交易时，送空; 格式：YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? DeliDate { get; set; }
        /// <summary>
        /// 交割日期char(8), 对应<see cref="DeliDate"/>
        /// </summary>
        [XmlElement("deliDate")]
        public string DeliDateStr
        {
            get
            {
                return this.DeliDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.DeliDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DeliDate = tmp;
                }
            }
        }
        /// <summary>
        /// 即期汇率decimal(19,8), 交易方式为即期外汇交易时，必输；交易方式为掉期外汇交易和远期外汇交易时，送空
        /// </summary>
        [XmlElement("sexcRate")]
        public decimal? SexcRate { get; set; }
        /// <summary>
        /// 远期汇率decimal(19,8). 交易方式为远期外汇交易时，必输；交易方式为即期外汇交易和掉期外汇交易时，送空
        /// </summary>
        [XmlElement("forwdRate")]
        public decimal? ForwdRate { get; set; }
        /// <summary>
        /// 备注char(60),可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 信银国际外汇交易号（原掉期交易）char(20), 交易方式为掉期外汇交易时选填; 交易方式为远期外汇交易和即期外汇交易时，送空
        /// </summary>
        [XmlElement("ceiforexNumber")]
        public string CeiforexNumber { get; set; }
        /// <summary>
        /// 近端交割日期char(8), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输; 格式：YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? NsetlDate { get; set; }
        /// <summary>
        /// 近端交割日期char(8), 对应<see cref="NsetlDate"/>
        /// </summary>
        [XmlElement("nsetlDate")]
        public string NsetlDateStr
        {
            get
            {
                return this.NsetlDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.NsetlDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NsetlDate = tmp;
                }
            }
        }
        /// <summary>
        /// 买入/卖出(近端) char(1), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输; 数据字典：0-买入；1-卖出
        /// </summary>
        [XmlElement("nType")]
        public string NType { get; set; }
        /// <summary>
        /// 买入币种(近端) char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="NType"/>标签为0-买入时必输，为1-卖出时选输; 数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD 、21-SEK、38-THB、93-ZAR
        /// </summary>
        [XmlElement("nincryType")]
        public string NincryType { get; set; }
        /// <summary>
        /// 买入金额 (近端) decimal(15,2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="NType"/>标签为0-买入时必输，为1-卖出时选输
        /// </summary>
        [XmlElement("ninAmt")]
        public decimal? NinAmt { get; set; }
        /// <summary>
        /// 近端汇率decimal(19,8), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输
        /// </summary>
        [XmlElement("nexcRate")]
        public decimal? NexcRate { get; set; }
        /// <summary>
        /// 卖出币种（近端）char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="NType"/>标签为1-卖出时必输，为0-买入时选输; 数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD 、21-SEK、38-THB、93-ZAR
        /// </summary>
        [XmlElement("noutcryType")]
        public string NoutcryType { get; set; }
        /// <summary>
        /// 卖出金额（近端）decimal(15,2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="NType"/>标签为1-卖出时必输，为0-买入时选输
        /// </summary>
        [XmlElement("noutAmt")]
        public decimal? NoutAmt { get; set; }
        /// <summary>
        /// 收款账号(近端) char(12), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输
        /// </summary>
        [XmlElement("nrcvAcc")]
        public string NrcvAcc { get; set; }
        /// <summary>
        /// 收款账户币种(近端) char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输；数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD
        /// </summary>
        [XmlElement("nrcvcType")]
        public string NrcvcType { get; set; }
        /// <summary>
        /// 付款账号(近端) char(12), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输
        /// </summary>
        [XmlElement("npayAcc")]
        public string NpayAcc { get; set; }
        /// <summary>
        /// 付款账户币种(近端) char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输；数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD
        /// </summary>
        [XmlElement("npaycryType")]
        public string NpaycryType { get; set; }
        /// <summary>
        /// 远端交割日期char(8), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输; 格式：YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? FsetlDate { get; set; }
        /// <summary>
        /// 远端交割日期char(8), 对应<see cref="FsetlDate"/>
        /// </summary>
        [XmlElement("fsetlDate")]
        public string FsetlDateStr
        {
            get
            {
                return this.FsetlDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.FsetlDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FsetlDate = tmp;
                }
            }
        }
        /// <summary>
        /// 买入/卖出 (远端) char(1), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输; 数据字典：0-买入；1-卖出
        /// </summary>
        [XmlElement("fType")]
        public string FType { get; set; }
        /// <summary>
        /// 买入币种(远端) char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="FType"/>标签为0-买入时必输，为1-卖出时选输; 数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD 、21-SEK、38-THB、93-ZAR
        /// </summary>
        [XmlElement("fincryType")]
        public string FincryType { get; set; }
        /// <summary>
        /// 买入金额(远端) decimal(15,2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="FType"/>标签为0-买入时必输，为1-卖出时选输
        /// </summary>
        [XmlElement("finAmt")]
        public decimal? FinAmt { get; set; }
        /// <summary>
        /// 远端汇率decimal(19,8), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输
        /// </summary>
        [XmlElement("fexcRate")]
        public decimal? FexcRate { get; set; }
        /// <summary>
        /// 卖出币种(远端）char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="FType"/>标签为1-卖出时必输，为0-买入时选输; 数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD 、21-SEK、38-THB、93-ZAR
        /// </summary>
        [XmlElement("foutcryType")]
        public string FoutcryType { get; set; }
        /// <summary>
        /// 卖出金额(远端) decimal(15,2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易，<see cref="FType"/>标签为1-卖出时必输，为0-买入时选输
        /// </summary>
        [XmlElement("foutAmt")]
        public decimal? FoutAmt { get; set; }
        /// <summary>
        /// 收款账号(远端) char(12), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输
        /// </summary>
        [XmlElement("frcvAcc")]
        public string FrcvAcc { get; set; }
        /// <summary>
        /// 收款账户币种(远端) char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输；数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD
        /// </summary>
        [XmlElement("frcvcryType")]
        public string FrcvcryType { get; set; }
        /// <summary>
        /// 付款账号(远端) char(12), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输
        /// </summary>
        [XmlElement("fpayAcc")]
        public string FpayAcc { get; set; }
        /// <summary>
        /// 付款账户币种(远端) char(2), 交易方式为即期外汇交易和远期外汇交易时，送空；交易方式为掉期外汇交易时，必输；数据字典：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、18-SGD、14-USD
        /// </summary>
        [XmlElement("fpaycryType")]
        public string FpaycryType { get; set; }
    }
}
