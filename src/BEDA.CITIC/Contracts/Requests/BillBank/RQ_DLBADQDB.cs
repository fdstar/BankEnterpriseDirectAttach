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
    /// 代保管票据信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBADQDB : RqBase<RS_DLBADQDB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBADQDB"; set { } }
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
        /// 代保管状态varchar(60)，可选多个状态，以|分割，状态值域见附录4.5(可选01、02、03、04、07、08、09、10、11、12、13、14、15、16、17)
        /// </summary>
        [XmlElement("agentStt")]
        public string AgentStt { get; set; }
        /// <summary>
        /// 票据号varchar(16)，可空
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 存票批次号varchar(20)，可空
        /// </summary>
        [XmlElement("billBathNo")]
        public string BillBathNo { get; set; }
        /// <summary>
        /// 票据ID int(20)，可空
        /// </summary>
        [XmlElement("billID")]
        public string BillID { get; set; }
        /// <summary>
        /// 票据类型char(4)，AC01：银承；AC02：商承，可空，为空时为全部类型
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
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
        /// 委托前手背书人名称varchar(122)，可空
        /// </summary>
        [XmlElement("preTendNm")]
        public string PreTendNm { get; set; }
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
