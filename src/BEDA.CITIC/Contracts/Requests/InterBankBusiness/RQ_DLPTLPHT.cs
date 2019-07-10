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
    /// 支付业务协议查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLPTLPHT : RqBase<RS_DLPTLPHT>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLPTLPHT"; set { } }
        /// <summary>
        /// 协议编号varchar(60) 可空
        /// </summary>
        [XmlElement("ptcID")]
        public string PtcID { get; set; }
        /// <summary>
        /// 付款机构号varchar(20) 可空
        /// </summary>
        [XmlElement("payAccBankNo")]
        public string PayAccBankNo { get; set; }
        /// <summary>
        /// 付款账号varchar(32) 可空
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 起始日期 char(8) 格式:YYYYMMDD 可空，为空时默认为当天
        /// </summary>
        [XmlIgnore]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 起始日期char(8) 格式YYYYMMDD, 对应<see cref="StartDate"/>
        /// </summary>
        [XmlElement("startDate")]
        public string StartDateStr
        {
            get
            {
                return this.StartDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.StartDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartDate = tmp;
                }
            }
        }
        /// <summary>
        /// 截止日期 char(8) 格式:YYYYMMDD 可空，为空时默认为当天
        /// </summary>
        [XmlIgnore]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 终止日期char(8) 格式YYYYMMDD, 对应<see cref="EndDate"/>
        /// </summary>
        [XmlElement("endDate")]
        public string EndDateStr
        {
            get
            {
                return this.EndDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.EndDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EndDate = tmp;
                }
            }
        }
    }
}
