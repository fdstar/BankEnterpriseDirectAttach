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
    /// 业务通知查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBCMBNQ : RqBase<RS_DLBCMBNQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBCMBNQ"; set { } }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30) 可空
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 通知日期上区间 char(8) 格式YYYYMMDD 可空
        /// </summary>
        [XmlIgnore]
        public DateTime? DueDateUp { get; set; }
        /// <summary>
        /// 通知日期上区间 char(8) 格式YYYYMMDD, 对应<see cref="DueDateUp"/>
        /// </summary>
        [XmlElement("dueDateUp")]
        public string DueDateUpStr
        {
            get
            {
                return this.DueDateUp?.ToString("yyyyMMdd");
            }
            set
            {
                this.DueDateUp = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DueDateUp = tmp;
                }
            }
        }
        /// <summary>
        /// 通知日期下区间 char(8) 格式YYYYMMDD 可空
        /// </summary>
        [XmlIgnore]
        public DateTime? DueDateDown { get; set; }
        /// <summary>
        /// 通知日期下区间 char(8) 格式YYYYMMDD, 对应<see cref="DueDateDown"/>
        /// </summary>
        [XmlElement("dueDateDown")]
        public string DueDateDownStr
        {
            get
            {
                return this.DueDateDown?.ToString("yyyyMMdd");
            }
            set
            {
                this.DueDateDown = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DueDateDown = tmp;
                }
            }
        }
        /// <summary>
        /// 通知类型 char(4) 见附录4.1.11
        /// </summary>
        [XmlElement("infoType")]
        public string InfoType { get; set; }
    }
}
