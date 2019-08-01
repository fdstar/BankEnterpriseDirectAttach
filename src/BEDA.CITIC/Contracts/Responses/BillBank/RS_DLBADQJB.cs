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
    /// 票据库经办查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBADQJB : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BillHandledQuery> List { get; set; }
    }
    /// <summary>
    /// 票据库经办
    /// </summary>
    public class BillHandledQuery
    {
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
        /// 存票批次号varchar(20)
        /// </summary>
        [XmlElement("billBathNo")]
        public string BillBathNo { get; set; }
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
        /// 付款人账号varchar(30)
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 付款人名称varchar(122)
        /// </summary>
        [XmlElement("payAccNm")]
        public string PayAccNm { get; set; }
        /// <summary>
        /// 付款人开户行名称varchar(122)
        /// </summary>
        [XmlElement("payBankNm")]
        public string PayBankNm { get; set; }
        /// <summary>
        /// 付款人开户行行号varchar(20)
        /// </summary>
        [XmlElement("payBankNo")]
        public string PayBankNo { get; set; }
        /// <summary>
        /// 付款人开户行地址varchar(60)
        /// </summary>
        [XmlElement("payBankAddress")]
        public string PayBankAddress { get; set; }
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
        /// 是否曾质押标志char(1)，0：否；1：是
        /// </summary>
        [XmlElement("hasImpnFlg")]
        public int HasImpnFlg { get; set; }
        /// <summary>
        /// 委托前手背书人名称varchar(122)
        /// </summary>
        [XmlElement("preTendNm")]
        public string PreTendNm { get; set; }
        /// <summary>
        /// 委托人是否已背书标志char(1)，格式0：否；1：是
        /// </summary>
        [XmlElement("hasTendFlg")]
        public int HasTendFlg { get; set; }
        /// <summary>
        /// 已背书手数int(3)
        /// </summary>
        [XmlElement("endrAmount")]
        public int EndrAmount { get; set; }
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
        /// 代保管状态char(2)，值域见附录4.5
        /// </summary>
        [XmlElement("agentStt")]
        public string AgentStt { get; set; }
        /// <summary>
        /// 银行备注varchar(256)
        /// </summary>
        [XmlElement("bankMemo")]
        public string BankMemo { get; set; }
        /// <summary>
        /// 客户备注varchar(512)
        /// </summary>
        [XmlElement("cstMemo")]
        public string CstMemo { get; set; }
    }
}
