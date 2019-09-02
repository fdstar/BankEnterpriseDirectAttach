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
    /// 交易结果查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLMTRNRQ : RqBase<RS_DLMTRNRQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLMTRNRQ"; set { } }
        /// <summary>
        /// 商户编号 varchar(4)
        /// </summary>
        [XmlElement("bizCode")]
        public string BizCode { get; set; }
        /// <summary>
        /// 起始日期char(8) 格式YYYYMMDD
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
        /// 终止日期char(8) 格式YYYYMMDD
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
        /// 查询类型 1：按时间； 2：按订单号char(1)
        /// </summary>
        [XmlElement("type")]
        public int Type { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<OrderQuery> Collection { get; set; }
    }
    /// <summary>
    /// 订单查询
    /// </summary>
    public class OrderQuery
    {
        /// <summary>
        /// 订单号varchar(20)  如果type为2时，该项不可空
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
    }
}
