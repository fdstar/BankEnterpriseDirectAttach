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
    /// 出票信息登记请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBILREG : RqBase<RS_DLBILREG>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBILREG"; set { } }
        /// <summary>
        /// 客户流水号 varchar (20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 信用等级 char(3) 可空
        /// </summary>
        [XmlElement("drwrRate")]
        public string DrwrRate { get; set; }
        /// <summary>
        /// 评级机构 varchar(60) 可空
        /// </summary>
        [XmlElement("drwrAgcy")]
        public string DrwrAgcy { get; set; }
        /// <summary>
        /// 评级到期日 char(8) 格式YYYYMMDD 可空
        /// </summary>
        [XmlIgnore]
        public DateTime? RateDueDate { get; set; }
        /// <summary>
        /// 评级到期日 char(8) 格式YYYYMMDD, 对应<see cref="RateDueDate"/>
        /// </summary>
        [XmlElement("rateDueDate")]
        public string RateDueDateStr
        {
            get
            {
                return this.RateDueDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.RateDueDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RateDueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 票据类型 char(4)， AC01银承 AC02商承
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 出票日 char(8)， 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime IssDate { get; set; }
        /// <summary>
        /// 出票日 char(8)， 格式YYYYMMDD, 对应<see cref="IssDate"/>
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
        /// 到期日 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 到期日 char(8)，格式YYYYMMDD, 对应<see cref="DueDate"/>
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
        /// 票据金额 decimal(15，2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 背书转让标志 char(4)， EM00可再转让 EM01不得转让
        /// </summary>
        [XmlElement("endorseMk")]
        public string EndorseMk { get; set; }
        /// <summary>
        /// 收款人名称 varchar(122)
        /// </summary>
        [XmlElement("pyeeName")]
        public string PyeeName { get; set; }
        /// <summary>
        /// 收款人账号 varchar(32) 
        /// </summary>
        [XmlElement("pyeeAccNo")]
        public string PyeeAccNo { get; set; }
        /// <summary>
        /// 收款人行号 varchar(20)
        /// </summary>
        [XmlElement("pyeeBnm")]
        public string PyeeBnm { get; set; }
        /// <summary>
        /// 承兑人名称 varchar(122) 
        /// </summary>
        [XmlElement("accpName")]
        public string AccpName { get; set; }
        /// <summary>
        /// 承兑人账号 varchar(32) 本行银承为0
        /// </summary>
        [XmlElement("accpAccNo")]
        public string AccpAccNo { get; set; }
        /// <summary>
        /// 承兑人行号 varchar(20)
        /// </summary>
        [XmlElement("accpBnm")]
        public string AccpBnm { get; set; }
        /// <summary>
        /// 承兑人是否为中信银行标志 char(1)，0:是1:否
        /// </summary>
        [XmlElement("accpIsCitic")]
        public int AccpIsCitic { get; set; }
        /// <summary>
        /// 合同编号 char(32)，可空
        /// </summary>
        [XmlElement("contractNo")]
        public string ContractNo { get; set; }
        /// <summary>
        /// 发票编号 char(30)，可空
        /// </summary>
        [XmlElement("invoiceNo")]
        public string InvoiceNo { get; set; }
        /// <summary>
        /// ECDS批次号 varchar(10) 在出票登记时该字段不起作用；在出票登记一键两功能、出票登记一键三功能时该字段起作用，可空，选填；不为空时必须为数字
        /// </summary>
        [XmlElement("ecdsBatNo")]
        public string EcdsBatNo { get; set; }
        /// <summary>
        /// 经办备注 varchar(256)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约1：预约 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 启用联动预约时间
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 预约支付日期 预约时非空 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("preDate")]
        public string PreDateStr
        {
            get
            {
                return this.AppointmentTime?.ToString("yyyyMMdd");
            }
            set { }
        }
    }
    /// <summary>
    /// 出票登记一键两功能请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBLREG2 : RqBase<RS_DLBILREG>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBLREG2"; set { } }
    }
    /// <summary>
    /// 出票登记一键三功能请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBLREG3 : RqBase<RS_DLBILREG>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBLREG3"; set { } }
    }
}
