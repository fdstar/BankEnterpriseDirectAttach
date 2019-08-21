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
    /// 订单通知查询确认(第三方支付)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DL3RDNTC : RqBase<RS_DL3RDNTC>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DL3RDNTC"; set { } }

        /// <summary>
        /// 查询时间 格式YYYYMMDDhhmmss
        /// </summary>
        [XmlIgnore]
        public DateTime QueryTime { get; set; }
        /// <summary>
        /// 查询时间 格式YYYYMMDDhhmmss, 对应<see cref="QueryTime"/>
        /// </summary>
        [XmlElement("queryTime")]
        public string QueryTimeStr
        {
            get
            {
                return this.QueryTime.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.QueryTime = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 订单通知查询确认(直联商户)请求内容
    /// </summary>
    public class RQ_DLB2CNTC : RQ_DL3RDFLE
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        public override string Action { get => "DLB2CNTC"; set { } }
    }
}
