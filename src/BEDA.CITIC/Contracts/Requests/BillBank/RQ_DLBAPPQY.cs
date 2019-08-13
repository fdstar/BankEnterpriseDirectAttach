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
    /// 电子申请信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBAPPQY : RqBase<RS_DLBAPPQY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBAPPQY"; set { } }
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
        /// 票据类型char(4)，AC01：银承；AC02：商承可空，为空时为全部类型
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 申请编号varchar(18)，可空
        /// </summary>
        [XmlElement("appNo")]
        public string AppNo { get; set; }
        /// <summary>
        /// 申请类型varchar(2)，值域见附录4.3，取值0、1、2、5、8之一，可空，为空时为全部类型
        /// </summary>
        [XmlElement("appType")]
        public string AppType { get; set; }
        /// <summary>
        /// 申请状态char(1)，值域见附录4.2，可空，为空时为全部状态
        /// </summary>
        [XmlElement("appStt")]
        public string AppStt { get; set; }
        /// <summary>
        /// 银行备注类型char(2)，值域见附录4.4，可空，为空时为全部类型
        /// </summary>
        [XmlElement("bankMemoType")]
        public string BankMemoType { get; set; }
        /// <summary>
        /// 起始申请日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StartAppDate { get; set; }
        /// <summary>
        /// 起始申请日期char(8)，格式YYYYMMDD, 对应<see cref="StartAppDate"/>
        /// </summary>
        [XmlElement("startAppDate")]
        public string StartAppDateStr
        {
            get
            {
                return this.StartAppDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartAppDate = tmp;
                }
            }
        }
        /// <summary>
        /// 截止申请日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime EndAppDate { get; set; }
        /// <summary>
        /// 截止申请日期char(8)，格式YYYYMMDD, 对应<see cref="EndAppDate"/>
        /// </summary>
        [XmlElement("endAppDate")]
        public string EndAppDateStr
        {
            get
            {
                return this.EndAppDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EndAppDate = tmp;
                }
            }
        }
    }
}
