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
    /// 对私付款-对账文件下载请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLUPRDWN : RqBase<RS_DLUPRDWN>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLUPRDWN"; set { } }
        /// <summary>
        /// 对账日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime CheckDate { get; set; }
        /// <summary>
        /// 对账日期 char(8)，格式YYYYMMDD, 对应<see cref="CheckDate"/>
        /// </summary>
        [XmlElement("checkDate")]
        public string CheckDateStr
        {
            get
            {
                return this.CheckDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CheckDate = tmp;
                }
            }
        }
        /// <summary>
        /// 付款账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
    }
}
