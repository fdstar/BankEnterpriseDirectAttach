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
    /// 电子申请信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBAPPQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ElectronicApplicationInfo> List { get; set; }
    }
    /// <summary>
    /// 电子申请信息
    /// </summary>
    public class ElectronicApplicationInfo
    {
        /// <summary>
        /// 票据号varchar(16)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 票据ID int(20)
        /// </summary>
        [XmlElement("billID")]
        public string BillID { get; set; }
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
        /// 存票日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StoreDate { get; set; }
        /// <summary>
        /// 存票日期char(8)，格式YYYYMMDD, 对应<see cref="StoreDate"/>
        /// </summary>
        [XmlElement("storeDate")]
        public string StoreDateStr
        {
            get
            {
                return this.StoreDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StoreDate = tmp;
                }
            }
        }
        /// <summary>
        /// 客户备注varchar(512)
        /// </summary>
        [XmlElement("cstMemo")]
        public string CstMemo { get; set; }
        /// <summary>
        /// 银行备注varchar(256)
        /// </summary>
        [XmlElement("bankMemo")]
        public string BankMemo { get; set; }
        /// <summary>
        /// 客户申请备注varchar(256)
        /// </summary>
        [XmlElement("cstAppMemo")]
        public string CstAppMemo { get; set; }
        /// <summary>
        /// 银行审核备注varchar(256)
        /// </summary>
        [XmlElement("bankAuditMemo")]
        public string BankAuditMemo { get; set; }
        /// <summary>
        /// 申请类型varchar(2)，值域见附录4.3
        /// </summary>
        [XmlElement("appType")]
        public string AppType { get; set; }
        /// <summary>
        /// 申请状态char(1)，值域见附录4.2
        /// </summary>
        [XmlElement("appStt")]
        public string AppStt { get; set; }
        /// <summary>
        /// 申请编号varchar(18)
        /// </summary>
        [XmlElement("appNo")]
        public string AppNo { get; set; }
        /// <summary>
        /// 申请日期char(8)
        /// </summary>
        [XmlIgnore]
        public DateTime AppDate { get; set; }
        /// <summary>
        /// 申请日期char(8), 对应<see cref="AppDate"/>
        /// </summary>
        [XmlElement("appDate")]
        public string AppDateStr
        {
            get
            {
                return this.AppDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.AppDate = tmp;
                }
            }
        }
        /// <summary>
        /// 代保管账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 代保管客户名称varchar(122)
        /// </summary>
        [XmlElement("cstNm")]
        public string CstNm { get; set; }
        /// <summary>
        /// 代保管机构号varchar(20)
        /// </summary>
        [XmlElement("agentBranchNo")]
        public string AgentBranchNo { get; set; }
        /// <summary>
        /// 代保管机构名称varchar(122)
        /// </summary>
        [XmlElement("agentBranchNm")]
        public string AgentBranchNm { get; set; }
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
        /// 付款人开户行地址varchar(60)
        /// </summary>
        [XmlElement("payBankAddress")]
        public string PayBankAddress { get; set; }
        /// <summary>
        /// 付款人名称varchar(122)
        /// </summary>
        [XmlElement("payAccNm")]
        public string PayAccNm { get; set; }
        /// <summary>
        /// 出票人名称varchar(122)
        /// </summary>
        [XmlElement("drwrName")]
        public string DrwrName { get; set; }
        /// <summary>
        /// 出票人账号varchar(30)
        /// </summary>
        [XmlElement("drwrAccNo")]
        public string DrwrAccNo { get; set; }
        /// <summary>
        /// 收款人名称varchar(122)
        /// </summary>
        [XmlElement("pyeeName")]
        public string PyeeName { get; set; }
        /// <summary>
        /// 收款人账号varchar(30)
        /// </summary>
        [XmlElement("pyeeAccNo")]
        public string PyeeAccNo { get; set; }
        /// <summary>
        /// 收款人开户行名称varchar(122)
        /// </summary>
        [XmlElement("pyeeBankNm")]
        public string PyeeBankNm { get; set; }
        /// <summary>
        /// 委托前手背书人名称varchar(122)
        /// </summary>
        [XmlElement("preTendNm")]
        public string PreTendNm { get; set; }
        /// <summary>
        /// 已背书手数int(3)
        /// </summary>
        [XmlElement("endrAmount")]
        public int EndrAmount { get; set; }
        /// <summary>
        /// 是否曾质押标志char(1)，0：否；1：是
        /// </summary>
        [XmlElement("hasImpnFlg")]
        public int HasImpnFlg { get; set; }
        /// <summary>
        /// 存票批次号varchar(20)
        /// </summary>
        [XmlElement("billBathNo")]
        public string BillBathNo { get; set; }
        /// <summary>
        /// 是否委托银行收款标志char(1)，0：否；1：是
        /// </summary>
        [XmlElement("autoColFlg")]
        public int AutoColFlg { get; set; }
        /// <summary>
        /// 托收回款账号varchar(30)
        /// </summary>
        [XmlElement("retmAccNo")]
        public string RetmAccNo { get; set; }
        /// <summary>
        /// 委托人是否已背书标志char(1)，格式0：否；1：是
        /// </summary>
        [XmlElement("hasTendFlg")]
        public int HasTendFlg { get; set; }
        /// <summary>
        /// 经办人姓名varchar(62)
        /// </summary>
        [XmlElement("operatorNm")]
        public string OperatorNm { get; set; }
        /// <summary>
        /// 经办日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime OperateDate { get; set; }
        /// <summary>
        /// 经办日期char(8)，格式YYYYMMDD, 对应<see cref="OperateDate"/>
        /// </summary>
        [XmlElement("operateDate")]
        public string OperateDateStr
        {
            get
            {
                return this.OperateDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OperateDate = tmp;
                }
            }
        }
        /// <summary>
        /// 审核人姓名varchar(62)
        /// </summary>
        [XmlElement("auditorNm")]
        public string AuditorNm { get; set; }
        /// <summary>
        /// 审核日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime AuditDate { get; set; }
        /// <summary>
        /// 审核日期char(8)，格式YYYYMMDD, 对应<see cref="AuditDate"/>
        /// </summary>
        [XmlElement("auditDate")]
        public string AuditDateStr
        {
            get
            {
                return this.AuditDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.AuditDate = tmp;
                }
            }
        }
        /// <summary>
        /// 业务受理机构联行号varchar(20)
        /// </summary>
        [XmlElement("bsnBranchNo")]
        public string BsnBranchNo { get; set; }
        /// <summary>
        /// 业务受理机构名称varchar(122)
        /// </summary>
        [XmlElement("bsnBranchNm")]
        public string BsnBranchNm { get; set; }
        /// <summary>
        /// 银行审批人姓名varchar(62)
        /// </summary>
        [XmlElement("bankAuditorNm")]
        public string BankAuditorNm { get; set; }
        /// <summary>
        /// 银行审批日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime BankAuditDate { get; set; }
        /// <summary>
        /// 银行审批日期char(8)，格式YYYYMMDD, 对应<see cref="BankAuditDate"/>
        /// </summary>
        [XmlElement("bankAuditDate")]
        public string BankAuditDateStr
        {
            get
            {
                return this.BankAuditDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BankAuditDate = tmp;
                }
            }
        }
        /// <summary>
        /// 取票人姓名varchar(60)
        /// </summary>
        [XmlElement("takerName")]
        public string TakerName { get; set; }
        /// <summary>
        /// 取票人证件号varchar(30)
        /// </summary>
        [XmlElement("takerID")]
        public string TakerID { get; set; }
        /// <summary>
        /// 取票人证件类型char(1)，值域见附录4.6
        /// </summary>
        [XmlElement("takerIDType")]
        public string TakerIDType { get; set; }
        /// <summary>
        /// 业务流水号varchar(18)
        /// </summary>
        [XmlElement("bsnFlwNo")]
        public string BsnFlwNo { get; set; }
    }
}
