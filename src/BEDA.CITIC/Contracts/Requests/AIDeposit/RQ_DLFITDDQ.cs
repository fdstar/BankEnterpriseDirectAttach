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
    /// 定期型智能存款明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFITDDQ : RqBase<RS_DLFITDDQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFITDDQ"; set { } }
        /// <summary>
        /// 智能存款账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 查询类型char(1) 1：未结清；2：已结清
        /// </summary>
        [XmlElement("qryType")]
        public int QryType { get; set; }
        /// <summary>
        /// 开始日期char(8)，格式YYYYMMDD，可空，当查询类型为2(已结清)时非空
        /// </summary>
        [XmlIgnore]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 开始日期char(8)，格式YYYYMMDD, 对应<see cref="StartDate"/>
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
        /// 截止日期char(8)，格式YYYYMMDD，可空，当查询类型为2(已结清)时非空
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
