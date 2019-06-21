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
    /// 附属账户交易明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLSUBDTL : RqBase<RS_DLSUBDTL>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLSUBDTL"; set { } }
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 起始日期 char(8)，格式YYYYMMDD
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
        /// 交易类型 char(1) 空：查询全部交易明细；1：查询待调账交易明细
        /// </summary>
        [XmlElement("tranType")]
        public int? TranType { get; set; }
        /// <summary>
        /// 起始金额 decimal(15,2) 可空
        /// </summary>
        [XmlElement("minAmt")]
        public decimal? MinAmt { get; set; }
        /// <summary>
        /// 截止金额 decimal(15,2) 可空
        /// </summary>
        [XmlElement("maxAmt")]
        public decimal? MaxAmt { get; set; }
        /// <summary>
        /// 控制标签char(1)，0：客户系统不兼容银行端新增返回字段1：客户系统兼容银行端新增返回字段，标签可空
        /// </summary>
        [XmlElement("controlFlag")]
        public int? ControlFlag { get; set; }
    }
}
