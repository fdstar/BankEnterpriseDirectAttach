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
    /// 收拨明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_CMMCDQRY : RqBase<RS_CMMCDQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "CMMCDQRY"; set { } }
        /// <summary>
        /// 核心账号char(19)，flowFlag为30时可空
        /// </summary>
        [XmlElement("coreAccountNo")]
        public string CoreAccountNo { get; set; }
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 流动性方向char(2)  00：归集下拨数据； 01：手动归集下拨数据； 02：自动归集下拨数据；10：归集数据； 11：手动归集； 12：自动归集；20：下拨数据；21：手动下拨； 22：自动下拨； 30：除归集下拨外数据
        /// </summary>
        [XmlElement("flowFlag")]
        public string FlowFlag { get; set; }
        /// <summary>
        /// 最小金额 decimal(15,2)
        /// </summary>
        [XmlElement("lowAmount")]
        public decimal LowAmount { get; set; }
        /// <summary>
        /// 最大金额 decimal(15,2)
        /// </summary>
        [XmlElement("upAmount")]
        public decimal UpAmount { get; set; }
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
        /// 终止日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 终止日期char(8) 格式YYYYMMDD, 对应<see cref="EndDate"/>
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
