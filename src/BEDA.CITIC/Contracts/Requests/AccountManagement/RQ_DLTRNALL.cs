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
    /// 账户明细信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLTRNALL : RqBase<RS_DLTRNALL>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLTRNALL"; set { } }
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
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
        /// <summary>
        /// 请求记录条数，最大为20
        /// </summary>
        [XmlElement("pageNumber")]
        public int PageNumber { get; set; } = 20;
        /// <summary>
        /// 起始记录号 char(4)
        /// </summary>
        [XmlElement("startRecord")]
        public int StartRecord { get; set; }
        /// <summary>
        /// 控制标签char(1)，0：客户系统不兼容银行端新增返回字段 1：客户系统兼容银行端新增返回字段，标签可空
        /// </summary>
        [XmlElement("controlFlag")]
        public string ControlFlag { get; set; }
    }
}
