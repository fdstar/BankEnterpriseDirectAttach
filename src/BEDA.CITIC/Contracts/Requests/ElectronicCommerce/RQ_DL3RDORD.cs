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
    /// 指定时间段订单查询(第三方支付)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DL3RDORD : RqBase<RS_DL3RDORD>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DL3RDORD"; set { } }
        /// <summary>
        /// 起始时间YYYYMMDDhhmmss
        /// </summary>
        [XmlIgnore]
        public DateTime QryStartTime { get; set; }
        /// <summary>
        /// 起始时间YYYYMMDDhhmmss, 对应<see cref="QryStartTime"/>
        /// </summary>
        [XmlElement("qryStartTime")]
        public string QryStartTimeStr
        {
            get
            {
                return this.QryStartTime.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryStartTime = tmp;
                }
            }
        }
        /// <summary>
        /// 截止时间YYYYMMDDhhmmss
        /// </summary>
        [XmlIgnore]
        public DateTime QryEndTime { get; set; }
        /// <summary>
        /// 截止时间YYYYMMDDhhmmss, 对应<see cref="QryEndTime"/>
        /// </summary>
        [XmlElement("qryEndTime")]
        public string QryEndTimeStr
        {
            get
            {
                return this.QryEndTime.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QryEndTime = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 指定时间段订单查询(直联商户)请求内容
    /// </summary>
    public class RQ_DLB2CORD : RQ_DL3RDORD
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        public override string Action { get => "DLB2CORD"; set { } }
    }
}
