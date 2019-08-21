using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 订单通知查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DL3RDNTQ : RsBase
    {
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

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<EOrderNotification> List { get; set; }
    }
    /// <summary>
    /// 订单通知
    /// </summary>
    public class EOrderNotification
    {
        /// <summary>
        /// 消息创建时间 格式YYYYMMDDHHmmss
        /// </summary>
        [XmlIgnore]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 消息创建时间 格式YYYYMMDDHHmmss, 对应<see cref="CreateTime"/>
        /// </summary>
        [XmlElement("createTime")]
        public string CreateTimeStr
        {
            get
            {
                return this.CreateTime.ToString("yyyyMMddHHmmss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CreateTime = tmp;
                }
            }
        }
        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("msgContent")]
        public string MsgContent { get; set; }
    }
}
