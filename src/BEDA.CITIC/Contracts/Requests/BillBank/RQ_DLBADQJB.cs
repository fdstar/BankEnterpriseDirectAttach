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
    /// 票据库经办查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBADQJB : RqBase<RS_DLBADQJB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBADQJB"; set { } }
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
        /// 起始存票日char(8)，可空，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? StartStoreDate { get; set; }
        /// <summary>
        /// 起始存票日char(8) 格式YYYYMMDD, 对应<see cref="StartStoreDate"/>
        /// </summary>
        [XmlElement("startStoreDate")]
        public string StartStoreDateStr
        {
            get
            {
                return this.StartStoreDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.StartStoreDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartStoreDate = tmp;
                }
            }
        }
        /// <summary>
        /// 截止存票日char(8)，可空，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? EndStoreDate { get; set; }
        /// <summary>
        /// 截止存票日char(8) 格式YYYYMMDD, 对应<see cref="EndStoreDate"/>
        /// </summary>
        [XmlElement("endStoreDate")]
        public string EndStoreDateStr
        {
            get
            {
                return this.EndStoreDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.EndStoreDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EndStoreDate = tmp;
                }
            }
        }
        /// <summary>
        /// 起始到期日char(8)，可空，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? StartDueDate { get; set; }
        /// <summary>
        /// 起始到期日char(8) 格式YYYYMMDD, 对应<see cref="StartDueDate"/>
        /// </summary>
        [XmlElement("startDueDate")]
        public string StartDueDateStr
        {
            get
            {
                return this.StartDueDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.StartDueDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartDueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 截止到期日char(8)，可空，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? EndDueDate { get; set; }
        /// <summary>
        /// 截止到期日char(8) 格式YYYYMMDD, 对应<see cref="EndDueDate"/>
        /// </summary>
        [XmlElement("endDueDate")]
        public string EndDueDateStr
        {
            get
            {
                return this.EndDueDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.EndDueDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EndDueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 票据号varchar(16)，可空
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 票据类型char(4)，AC01：银承；AC02：商承，可空，为空时为全部类型
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 存票批次号varchar(20)，可空
        /// </summary>
        [XmlElement("billBathNo")]
        public string BillBathNo { get; set; }
        /// <summary>
        /// 委托前手背书人名称varchar(122)，可空
        /// </summary>
        [XmlElement("preTendNm")]
        public string PreTendNm { get; set; }
        /// <summary>
        /// 是否曾质押标志char(1)，0：否；1：是，可空，为空时为全部类型
        /// </summary>
        [XmlElement("hasImpnFlg")]
        public string HasImpnFlg { get; set; }
        /// <summary>
        /// 申请类型varchar(2)，值域见附录4.3，取值1-9
        /// </summary>
        [XmlElement("appType")]
        public string AppType { get; set; }
        /// <summary>
        /// 承兑人名称varchar(122)，可空
        /// </summary>
        [XmlElement("payAccNm")]
        public string PayAccNm { get; set; }
        /// <summary>
        /// 银行备注类型char(2)，值域见附录4.4，可空，为空时为全部类型
        /// </summary>
        [XmlElement("bankMemoType")]
        public string BankMemoType { get; set; }
        /// <summary>
        /// 起始票面金额decimal(15,2)，可空
        /// </summary>
        [XmlElement("minAmt")]
        public decimal? MinAmt { get; set; }
        /// <summary>
        /// 截止票面金额decimal(15,2)，可空
        /// </summary>
        [XmlElement("maxAmt")]
        public decimal? MaxAmt { get; set; }
    }
}
