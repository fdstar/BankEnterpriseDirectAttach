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
    /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请请求主体
    /// </summary>
    public class V1_EBDISCNTTRNRQ : IRequest<V1_EBDISCNTTRNRS>
    {
        /// <summary>
        /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请请求主体
        /// </summary>
        public EBDISCNTTRNRQ EBDISCNTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请请求主体
    /// </summary>
    public class EBDISCNTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBDISCNTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请请求内容
    /// </summary>
    public class EBDISCNTTRN_RQBODY
    {
        /// <summary>
        /// 票据总笔数,8位整数	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT
        {
            get
            {
                return this.List?.Count ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 票据总金额, 17位(15整数位,2小数位) 	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT
        {
            get
            {
                return this.List?.Sum(c => c.BILLAMT) ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 交易类型,4位 (TT00:贴现,TT01:转贴现,TT02:再贴现)	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string TRADETYPE { get; set; }
        /// <summary>
        /// 申请日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/> 必输
        /// </summary>
        [XmlElement("APPDATE", Order = 6)]
        public string APPDATEStr
        {
            get
            {
                return this.APPDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 票据类型,4位(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 贴出人信息 必输
        /// </summary>
        [XmlElement(Order = 8)]
        public ACCT ACCTFROM { get; set; }
        /// <summary>
        /// 贴入人账户代号是否兴业账户代号,1位 (Y:是,N:否)	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string ISCIB { get; set; }
        /// <summary>
        /// 贴入人账户信息	必输 不传递 BANKDESC
        /// </summary>
        [XmlElement(Order = 10)]
        public CORRELATEACCT ACCTTO { get; set; }
        /// <summary>
        /// 贴现类型,4位 (RM00:买断式, RM01:回购式)	非必输
        /// </summary>
        [XmlElement(Order = 11)]
        public string DISCNTTYPE { get; set; }
        /// <summary>
        /// 贴现利率,7位百分数不含百分号 (2位整数,5位小数)	必输
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal INTRSTRATE { get; set; }
        /// <summary>
        /// 转让标识 4位(EM00:可再转让,EM01:不可再转让)
        /// </summary>
        [XmlElement(Order = 13)]
        public string NEGTBL { get; set; }
        /// <summary>
        /// 赎回日期范围	非必输
        /// </summary>
        [XmlElement(Order = 14)]
        public DATERANGE REDMDATE { get; set; }
        /// <summary>
        /// 赎回利率,7位百分数不含百分号 (2位整数,5位小数)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? REDMINTRSTRATE { get; set; }
        /// <summary>
        /// 赎回利率,7位百分数不含百分号 (2位整数,5位小数) 对应<see cref="REDMINTRSTRATE"/>	非必输
        /// </summary>
        [XmlElement("REDMINTRSTRATE", Order = 15)]
        public string REDMINTRSTRATEStr
        {
            get
            {
                return this.REDMINTRSTRATE?.ToString();
            }
            set
            {
                this.REDMINTRSTRATE = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 交易合同号,最大30位	非必输
        /// </summary>
        [XmlElement(Order = 16)]
        public string CONTRACTID { get; set; }
        /// <summary>
        /// 发票号码,最大30位	非必输
        /// </summary>
        [XmlElement(Order = 17)]
        public string INVCNO { get; set; }
        /// <summary>
        /// 贴出人备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 18)]
        public string MEMO { get; set; }
        /// <summary>
        /// 清算模式,4位 (SM00:线上清算,SM01:线下清算)	必输
        /// </summary>
        [XmlElement(Order = 19)]
        public string LQMODE { get; set; }
        /// <summary>
        /// 入账账户代号,最大32位	非必输
        /// </summary>
        [XmlElement(Order = 20)]
        public string INACCTID { get; set; }
        /// <summary>
        /// 入账行号,最大12位	非必输
        /// </summary>
        [XmlElement(Order = 21)]
        public string INBANKNUM { get; set; }
        /// <summary>
        /// 贴现申请付息方式：1－卖方付息 2－买方付息 转贴现申请与再贴现申请不必输入 非必输
        /// </summary>
        [XmlElement(Order = 22)]
        public string PAYINTRMODE { get; set; }
        /// <summary>
        /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<EBDISCNTTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请请求明细
    /// </summary>
    public class EBDISCNTTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 实付金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal REALPAY { get; set; }
        /// <summary>
        /// 赎回金额,17位(15整数位,2小数位)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? REDMAMT { get; set; }
        /// <summary>
        /// 赎回金额,17位(15整数位,2小数位) 对应<see cref="REDMAMT"/>	非必输
        /// </summary>
        [XmlElement("REDMAMT", Order = 4)]
        public string REDMAMTStr
        {
            get
            {
                return this.REDMAMT?.ToString();
            }
            set
            {
                this.REDMAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 票据到期日，YYYY-MM-DD 非必输 贴现类型为RM00:买断式时必输
        /// </summary>
        [XmlIgnore]
        public DateTime? DUEDATE { get; set; }
        /// <summary>
        /// 票据到期日 YYYY-MM-DD ,对应<see cref="DUEDATE"/> 非必输 贴现类型为RM00:买断式时必输
        /// </summary>
        [XmlElement("DUEDATE", Order = 5)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DUEDATE = value.TryConvert<DateTime>();
            }
        }
    }
}
