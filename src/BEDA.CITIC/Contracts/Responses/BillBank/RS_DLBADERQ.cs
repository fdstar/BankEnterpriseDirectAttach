using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// ECDS登记信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBADERQ : RsBase
    {
        /// <summary>
        /// 总笔数int
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 票据号varchar(16)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 票据类型char(4)，AC01：银承；AC02：商承
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 票面金额decimal(15,2)
        /// </summary>
        [XmlElement("billAmt")]
        public decimal BillAmt { get; set; }
        /// <summary>
        /// 出票日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime IssDate { get; set; }
        /// <summary>
        /// 出票日期char(8)，格式YYYYMMDD, 对应<see cref="IssDate"/>
        /// </summary>
        [XmlElement("issDate")]
        public string IssDateStr
        {
            get
            {
                return this.IssDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.IssDate = tmp;
                }
            }
        }
        /// <summary>
        /// 票据到期日char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 票据到期日char(8)，格式YYYYMMDD, 对应<see cref="DueDate"/>
        /// </summary>
        [XmlElement("dueDate")]
        public string DueDateStr
        {
            get
            {
                return this.DueDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 付款人开户行行号varchar(20)
        /// </summary>
        [XmlElement("payBankNo")]
        public string PayBankNo { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ECDSRegistrationInfo> List { get; set; }
    }
    /// <summary>
    /// ECDS登记信息
    /// </summary>
    public class ECDSRegistrationInfo
    {
        /// <summary>
        /// 登记信息类型char(2)，值域见附录4.7
        /// </summary>
        [XmlElement("infoType")]
        public string InfoType { get; set; }
        /// <summary>
        /// 出票人名称varchar(122)
        /// </summary>
        [XmlElement("drwrName")]
        public string DrwrName { get; set; }
        /// <summary>
        /// 付款人名称varchar(122)
        /// </summary>
        [XmlElement("payAccNm")]
        public string PayAccNm { get; set; }
        /// <summary>
        /// 收票人名称varchar(122)
        /// </summary>
        [XmlElement("pyeeName")]
        public string PyeeName { get; set; }
        /// <summary>
        /// 发起人名称varchar(122)
        /// </summary>
        [XmlElement("orgnName")]
        public string OrgnName { get; set; }
        /// <summary>
        /// 接收人名称varchar(122)
        /// </summary>
        [XmlElement("recName")]
        public string RecName { get; set; }
        /// <summary>
        /// 委托收款银行名称varchar(122)
        /// </summary>
        [XmlElement("entrBankName")]
        public string EntrBankName { get; set; }
        /// <summary>
        /// 已背书手数int(3)
        /// </summary>
        [XmlElement("endrAmount")]
        public int EndrAmount { get; set; }
        /// <summary>
        /// 委托收款日期char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime EntrDate { get; set; }
        /// <summary>
        /// 委托收款日期char(8), 对应<see cref="EntrDate"/>
        /// </summary>
        [XmlElement("entrDate")]
        public string EntrDateStr
        {
            get
            {
                return this.EntrDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EntrDate = tmp;
                }
            }
        }
        /// <summary>
        /// 最后一手持票人信息varchar(60)
        /// </summary>
        [XmlElement("lastOwnerInfo")]
        public string LastOwnerInfo { get; set; }
        /// <summary>
        /// 拒付理由代码char(4)，值域见附录4.8
        /// </summary>
        [XmlElement("refuseResCD")]
        public string RefuseResCD { get; set; }
        /// <summary>
        /// 拒付备注信息varchar(60)
        /// </summary>
        [XmlElement("refuseMemo")]
        public string RefuseMemo { get; set; }
        /// <summary>
        /// 止付类型char(4)，AS00：挂失止付 AS01：公示催告止付
        /// </summary>
        [XmlElement("tranType")]
        public string TranType { get; set; }
        /// <summary>
        /// 交易日期char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime TranDate { get; set; }
        /// <summary>
        /// 交易日期char(8), 对应<see cref="TranDate"/>
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
        /// 备注varchar(40)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
