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
    /// 业务明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBSNDQY : RqBase<RS_DLBSNDQY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBSNDQY"; set { } }
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
        /// 票据号varchar(16)，可空
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 票据ID int(20)，可空
        /// </summary>
        [XmlElement("billID")]
        public string BillID { get; set; }
        /// <summary>
        /// 票据类型char(4)，AC01：银承；AC02：商承可空，为空时为全部类型
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 业务类型varchar(2)，值域见附录4.9，可空，为空时为全部类型
        /// </summary>
        [XmlElement("bsnType")]
        public string BsnType { get; set; }
        /// <summary>
        /// 业务流水号varchar(18)，可空
        /// </summary>
        [XmlElement("bsnFlwNo")]
        public string BsnFlwNo { get; set; }
        /// <summary>
        /// 银行备注类型char(2)，值域见附录4.4，可空，为空时为全部类型
        /// </summary>
        [XmlElement("bankMemoType")]
        public string BankMemoType { get; set; }
        /// <summary>
        /// 起始业务发生日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StartBsnDate { get; set; }
        /// <summary>
        /// 起始业务发生日期char(8)，格式YYYYMMDD, 对应<see cref="StartBsnDate"/>
        /// </summary>
        [XmlElement("startBsnDate")]
        public string StartBsnDateStr
        {
            get
            {
                return this.StartBsnDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartBsnDate = tmp;
                }
            }
        }
        /// <summary>
        /// 截止业务发生日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime EndBsnDate { get; set; }
        /// <summary>
        /// 截止业务发生日期char(8)，格式YYYYMMDD, 对应<see cref="EndBsnDate"/>
        /// </summary>
        [XmlElement("endBsnDate")]
        public string EndBsnDateStr
        {
            get
            {
                return this.EndBsnDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EndBsnDate = tmp;
                }
            }
        }
    }
}
