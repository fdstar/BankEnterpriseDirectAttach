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
    /// 代保管存票申请请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBADSAV : RqBase<RS_DLBADSAV>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBADSAV"; set { } }
        /// <summary>
        /// 客户流水号varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 代保管账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 代保管机构号varchar(20)
        /// </summary>
        [XmlElement("agentBranchNo")]
        public string AgentBranchNo { get; set; }
        /// <summary>
        /// 存票批次号varchar(20)，可空
        /// </summary>
        [XmlElement("billBathNo")]
        public string BillBathNo { get; set; }
        /// <summary>
        /// 票据类型char(4)，AC01：银承；AC02：商承
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 票据号varchar(16)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 付款人开户行行号varchar(20)
        /// </summary>
        [XmlElement("payBankNo")]
        public string PayBankNo { get; set; }
        /// <summary>
        /// 付款人开户行名称varchar(122)
        /// </summary>
        [XmlElement("payBankNm")]
        public string PayBankNm { get; set; }
        /// <summary>
        /// 付款人开户行地址varchar(60)，可空
        /// </summary>
        [XmlElement("payBankAddress")]
        public string PayBankAddress { get; set; }
        /// <summary>
        /// 付款人账号varchar(30)，可空，票据类型为AC02(商承)时有效
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 付款人名称varchar(122)，可空，票据类型为AC02(商承)时必输
        /// </summary>
        [XmlElement("payAccNm")]
        public string PayAccNm { get; set; }
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
        /// 票面金额decimal(15,2)
        /// </summary>
        [XmlElement("billAmt")]
        public decimal BillAmt { get; set; }
        /// <summary>
        /// 出票人名称varchar(122)
        /// </summary>
        [XmlElement("drwrName")]
        public string DrwrName { get; set; }
        /// <summary>
        /// 出票人账号varchar(30)，可空
        /// </summary>
        [XmlElement("drwrAccNo")]
        public string DrwrAccNo { get; set; }
        /// <summary>
        /// 收款人名称varchar(122)
        /// </summary>
        [XmlElement("pyeeName")]
        public string PyeeName { get; set; }
        /// <summary>
        /// 收款人账号varchar(30)，可空
        /// </summary>
        [XmlElement("pyeeAccNo")]
        public string PyeeAccNo { get; set; }
        /// <summary>
        /// 收款人开户行名称varchar(122)，可空
        /// </summary>
        [XmlElement("pyeeBankNm")]
        public string PyeeBankNm { get; set; }
        /// <summary>
        /// 委托前手背书人名称varchar(122)，可空
        /// </summary>
        [XmlElement("preTendNm")]
        public string PreTendNm { get; set; }
        /// <summary>
        /// 是否曾质押标志char(1)，0：否；1：是
        /// </summary>
        [XmlElement("hasImpnFlg")]
        public int HasImpnFlg { get; set; }
        /// <summary>
        /// 是否委托银行收款标志char(1)，0：否；1：是
        /// </summary>
        [XmlElement("autoColFlg")]
        public int AutoColFlg { get; set; }
        /// <summary>
        /// 托收回款账号varchar(30)，可空，当autoColFlg 为1时非空
        /// </summary>
        [XmlElement("retmAccNo")]
        public string RetmAccNo { get; set; }
        /// <summary>
        /// 委托人是否已背书标志char(1)，格式0：否；1：是
        /// </summary>
        [XmlElement("hasTendFlg")]
        public int HasTendFlg { get; set; }
        /// <summary>
        /// 已背书手数int(3)，可空，hasTendFlg 为1时非空
        /// </summary>
        [XmlElement("endrAmount")]
        public int? EndrAmount { get; set; }
        /// <summary>
        /// 预约标志char(1)，0：非预约；1：预约
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 预约日期
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 预约日期char(8)，格式YYYYMMDD，可空，预约标志为1(预约)时非空
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
}
