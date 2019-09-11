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
    /// 放款通知详情查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCLFMPQ : RsBase
    {
        /// <summary>
        /// 通知书编号 varchar(30)
        /// </summary>
        [XmlElement("ntcNo")]
        public string NtcNo { get; set; }
        /// <summary>
        /// 借款企业组织机构代码 varchar(12)
        /// </summary>
        [XmlElement("orgCode")]
        public string OrgCode { get; set; }
        /// <summary>
        /// 借款企业ID varchar(20)，企业客户号
        /// </summary>
        [XmlElement("lonCpID")]
        public string LonCpID { get; set; }
        /// <summary>
        /// 授信产品 varchar(20) ，取值为：银行承兑汇票；流动资金贷款；法人账户透支；商票贴现；国内信用证；进口信用证；非信用证项下进口押汇
        /// </summary>
        [XmlElement("cdtprod")]
        public string Cdtprod { get; set; }
        /// <summary>
        /// 收款人ID varchar(40)
        /// </summary>
        [XmlElement("payID")]
        public string PayID { get; set; }
        /// <summary>
        /// 收款人账号 varchar(30)
        /// </summary>
        [XmlElement("payAcct")]
        public string PayAcct { get; set; }
        /// <summary>
        /// 收款人账号开户行 varchar(122)
        /// </summary>
        [XmlElement("payAcctBk")]
        public string PayAcctBk { get; set; }
        /// <summary>
        /// 融资金额 decimal(19,2)
        /// </summary>
        [XmlElement("lonAmt")]
        public decimal LonAmt { get; set; }
        /// <summary>
        /// 通知日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime NtcDt { get; set; }
        /// <summary>
        /// 通知日期 char(8)，格式YYYYMMDD, 对应<see cref="NtcDt"/>
        /// </summary>
        [XmlElement("ntcDt")]
        public string NtcDtStr
        {
            get
            {
                return this.NtcDt.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NtcDt = tmp;
                }
            }
        }
        /// <summary>
        /// 属性1 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
        
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<LoanNotice> List { get; set; }
    }
    /// <summary>
    ///  放款通知详情
    /// </summary>
    public class LoanNotice
    {
        /// <summary>
        /// 收款人ID varchar(40)
        /// </summary>
        [XmlElement("payID")]
        public string PayID { get; set; }
        /// <summary>
        /// 收款人账号 varchar(30)
        /// </summary>
        [XmlElement("payAcct")]
        public string PayAcct { get; set; }
        /// <summary>
        /// 收款人账号开户行 varchar(122)
        /// </summary>
        [XmlElement("payAcctBk")]
        public string PayAcctBk { get; set; }
        /// <summary>
        /// 融资起始日 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime LonSdt { get; set; }
        /// <summary>
        /// 融资起始日 char(8)，格式YYYYMMDD, 对应<see cref="LonSdt"/>
        /// </summary>
        [XmlElement("lonSdt")]
        public string LonSdtStr
        {
            get
            {
                return this.LonSdt.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LonSdt = tmp;
                }
            }
        }
        /// <summary>
        /// 融资到期日 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime LonMatrt { get; set; }
        /// <summary>
        /// 融资到期日 char(8)，格式YYYYMMDD, 对应<see cref="LonMatrt"/>
        /// </summary>
        [XmlElement("lonMatrt")]
        public string LonMatrtStr
        {
            get
            {
                return this.LonMatrt.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LonMatrt = tmp;
                }
            }
        }
        /// <summary>
        /// 属性4 varchar(122)，收款人名称，按约定返回
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
        /// <summary>
        /// 属性5 varchar(100)，票号，按约定返回
        /// </summary>
        [XmlElement("field5")]
        public string Field5 { get; set; }
        /// <summary>
        /// 属性6 varchar(122)，出票行，按约定返回
        /// </summary>
        [XmlElement("field6")]
        public string Field6 { get; set; }
        /// <summary>
        /// 属性7 varchar(122)，承兑人名称，按约定返回
        /// </summary>
        [XmlElement("field7")]
        public string Field7 { get; set; }
        /// <summary>
        /// 属性8 varchar(30)，承兑人账号，按约定返回
        /// </summary>
        [XmlElement("field8")]
        public string Field8 { get; set; }
        /// <summary>
        /// 属性9 varchar(30)，承兑人开户行行号，按约定返回
        /// </summary>
        [XmlElement("field9")]
        public string Field9 { get; set; }
        /// <summary>
        /// 属性10 varchar(122)，承兑人开户行名称，按约定返回
        /// </summary>
        [XmlElement("field10")]
        public string Field10 { get; set; }
    }
}
