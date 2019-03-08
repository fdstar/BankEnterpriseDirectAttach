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
    /// 3.9.3.17电子商业汇票开票明细业务登记簿响应主体
    /// </summary>
    public class V1_EBPOPENBILLREGISTERTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.17电子商业汇票开票明细业务登记簿响应主体
        /// </summary>
        public EBPOPENBILLREGISTERTRNRS EBPOPENBILLREGISTERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.17电子商业汇票开票明细业务登记簿响应主体
    /// </summary>
    public class EBPOPENBILLREGISTERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.17电子商业汇票开票明细业务登记簿响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPOPENBILLREGISTERTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.17电子商业汇票开票明细业务登记簿响应内容
    /// </summary>
    public class EBPOPENBILLREGISTERTRN_RSBODY
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
        /// 3.9.3.17电子商业汇票开票明细业务登记簿响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<EBPOPENBILLREGISTERTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.3.17电子商业汇票开票明细业务登记簿响应内容
    /// </summary>
    public class EBPOPENBILLREGISTERTRN_CONTENT
    {
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string CUSTNAME { get; set; }
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
        /// 承兑合同编号	必回
        /// </summary>
        [XmlElement(Order = 22)]
        public string ACCEPTCONTRACTNO { get; set; }
        /// <summary>
        /// 业务担保方式	必回
        /// </summary>
        [XmlElement(Order = 23)]
        public string MARGINTYPE { get; set; }
        /// <summary>
        /// 业务状态 必回
        /// 0-未结清   
        /// 1-已结清
        /// 2-已为用退回  
        /// 3-久悬
        /// </summary>
        [XmlElement(Order = 24)]
        public string BIZSTATUS { get; set; }
        /// <summary>
        /// 托收状态 必回
        /// 0-未收到托收
        /// 1-已收到托收
        /// </summary>
        [XmlElement(Order = 25)]
        public string COLLECTIONSTATUS { get; set; }
        /// <summary>
        /// 交易日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime TRADEDATE { get; set; }
        /// <summary>
        /// 交易日期，格式yyyy-MM-dd ,对应<see cref="TRADEDATE"/> 必回
        /// </summary>
        [XmlElement("TRADEDATE", Order = 27)]
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
        /// 归属机构号	必回
        /// </summary>
        [XmlElement(Order = 28)]
        public string BELONGORGNO { get; set; }
        /// <summary>
        /// 归属机构名称	必回
        /// </summary>
        [XmlElement(Order = 29)]
        public string BELONGORGNAME { get; set; }
    }
}
