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
    /// 贷款信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCRTQRY : RqBase<RS_DLCRTQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCRTQRY"; set { } }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 贷款类型 char(1) 0：全部；1：结清；2：未结清
        /// </summary>
        [XmlElement("qryType")]
        public int QryType { get; set; }
        /// <summary>
        /// 起始日期 char(8) 格式:YYYYMMDD 可空，起始日期、截止日期同时为空时，默认查询区间为当天
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
        /// 截止日期 char(8) 格式:YYYYMMDD 可空，起始日期、截止日期同时为空时，默认查询区间为当天
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
