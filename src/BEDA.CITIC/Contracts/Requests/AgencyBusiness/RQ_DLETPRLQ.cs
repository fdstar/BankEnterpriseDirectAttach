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
    /// 代理支付明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLETPRLQ : RqBase<RS_DLETPRLQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLETPRLQ"; set { } }
        /// <summary>
        /// 付款账号char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 客户内部账号varchar(30) ，可空
        /// </summary>
        [XmlElement("cstAccNo")]
        public string CstAccNo { get; set; }
        /// <summary>
        /// 客户内部账户名称varchar(122) ，可空
        /// </summary>
        [XmlElement("cstAccNm")]
        public string CstAccNm { get; set; }
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
