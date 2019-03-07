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
    /// 3.9.3.15电子商业汇票出入池登记簿响应主体
    /// </summary>
    public class V1_EBPOUTINPOOLREGISTERTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.15电子商业汇票出入池登记簿响应主体
        /// </summary>
        public EBPOUTINPOOLREGISTERTRNRS EBPOUTINPOOLREGISTERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.15电子商业汇票出入池登记簿响应主体
    /// </summary>
    public class EBPOUTINPOOLREGISTERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.15电子商业汇票出入池登记簿响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPOUTINPOOLREGISTERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.15电子商业汇票出入池登记簿响应内容
    /// </summary>
    public class EBPOUTINPOOLREGISTERTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 票据总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 本次查询总金额	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 3.9.3.15电子商业汇票出入池登记簿响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPOUTINPOOLREGISTERTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.15电子商业汇票出入池登记簿响应内容
    /// </summary>
    public class EBPOUTINPOOLREGISTERTRN_CONTENT
    {
        /// <summary>
        /// 业务类型，01-入池02-出池	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 出入池方式，01-托管  02-质押	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string OUTINTYPE { get; set; }
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 保证金账号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 票据号码，16位	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票面金额(18，2)	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 票据介质，1-纸票  2-电票	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string BILLMEDIUM { get; set; }
        /// <summary>
        /// 票据类型，AC01-银承 AC02-商承	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime OUTDATE { get; set; }
        /// <summary>
        /// 出票日，格式yyyy-MM-dd ,对应<see cref="OUTDATE"/> 必回
        /// </summary>
        [XmlElement("OUTDATE", Order = 9)]
        public string OUTDATEStr
        {
            get
            {
                return this.OUTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OUTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 到期日，格式yyyy-MM-dd ,对应<see cref="DUEDATE"/> 必回
        /// </summary>
        [XmlElement("DUEDATE", Order = 10)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 出票人名称	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string DRAWERNAME { get; set; }
        /// <summary>
        /// 出票人账号	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string DRAWERACCTNO { get; set; }
        /// <summary>
        /// 承兑银行/企业	非必回
        /// </summary>
        [XmlElement(Order = 13)]
        public string ACCEPTBANK { get; set; }
        /// <summary>
        /// 收款人名称	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string PAYEENAME { get; set; }
        /// <summary>
        /// 收款人账号	非必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string PAYEEACCTNO { get; set; }
        /// <summary>
        /// 收款人开户行名称	非必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string PAYEEBANKNAME { get; set; }
        /// <summary>
        /// 收款人开户行行号	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public string PAYEEBANKCODE { get; set; }
        /// <summary>
        /// 付款行名称	必回
        /// </summary>
        [XmlElement(Order = 20)]
        public string DRAWERBANKNAME { get; set; }
        /// <summary>
        /// 付款行行号	必回
        /// </summary>
        [XmlElement(Order = 21)]
        public string DRAWERBANKCODE { get; set; }
        /// <summary>
        /// 担保合同编号，质押入池是必回	非必回
        /// </summary>
        [XmlElement(Order = 22)]
        public string BAILCONTRACTNO { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRADEDATE { get; set; }
        /// <summary>
        /// 交易日期，格式yyyy-MM-dd ,对应<see cref="TRADEDATE"/> 必回
        /// </summary>
        [XmlElement("TRADEDATE", Order = 23)]
        public string TRADEDATEStr
        {
            get
            {
                return this.TRADEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRADEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 质押率，质押入池是必回	非必回
        /// </summary>
        [XmlElement(Order = 24)]
        public decimal? LOANTOVALUERATIO { get; set; }
        /// <summary>
        /// 归属机构号	必回
        /// </summary>
        [XmlElement(Order = 25)]
        public string BELONGORGNO { get; set; }
        /// <summary>
        /// 归属机构名称	必回
        /// </summary>
        [XmlElement(Order = 26)]
        public string BELONGORGNAME { get; set; }
    }
}
