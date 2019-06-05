using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests.AccountManagement
{
    /// <summary>
    /// 账户历史余额查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLHBLQRY : RqBase<RS_DLHBLQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLHBLQRY"; set { } }
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 起始日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 起始日期char(8) 格式YYYYMMDD, 对应<see cref="StartDate"/>
        /// </summary>
        [XmlElement("startDate")]
        public string StartDateStr
        {
            get
            {
                return this.StartDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartDate = tmp;
                }
            }
        }
        /// <summary>
        /// 截止日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 截止日期 char(8)，格式YYYYMMDD, 对应<see cref="EndDate"/>
        /// </summary>
        [XmlElement("endDate")]
        public string EndDateStr
        {
            get
            {
                return this.EndDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EndDate = tmp;
                }
            }
        }
    }
}
