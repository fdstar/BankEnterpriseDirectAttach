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
    /// 不归集额度计划管理经办查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLPLMQRY : RqBase<RS_DLPLMQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLPLMQRY"; set { } }
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 现金池ID  char(8) 由现金池信息查询结果获取
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 起始日期 char(8) 格式YYYYMMDD，可空，为空时默认为当天
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
        /// 截止日期 char(8) 格式YYYYMMDD 可空，为空时默认为当天
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
        /// <summary>
        /// 起始金额 decimal(15,2)可空，为空时默认为0.00
        /// </summary>
        [XmlElement("minAmt")]
        public decimal? MinAmt { get; set; }
        /// <summary>
        /// 截止金额 decimal(15,2) 可空，为空时默认为9999999999999.99
        /// </summary>
        [XmlElement("maxAmt")]
        public decimal? MaxAmt { get; set; }
    }
}
