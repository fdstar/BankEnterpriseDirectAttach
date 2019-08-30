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
    /// 上下行短信查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLPMMSGQ : RqBase<RS_DLPMMSGQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLPMMSGQ"; set { } }
        /// <summary>
        /// 商户编号 varchar(4)
        /// </summary>
        [XmlElement("bizCode")]
        public string BizCode { get; set; }
        /// <summary>
        /// 手机号 varchar(11)
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 订单号 varchar(20)
        /// </summary>
        [XmlElement("orderNo")]
        public string OrderNo { get; set; }
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
        /// 短信类型 0：主动付款；1：订单付款；2：订单通知；3：签约通知；9：全部 char(1) 
        /// </summary>
        [XmlElement("txtType")]
        public int TxtType { get; set; } = 9;
        /// <summary>
        /// 上下行 char(1) 0：上行；1：下行；9：全部
        /// </summary>
        [XmlElement("smsType")]
        public int SmsType { get; set; } = 9;
    }
}
