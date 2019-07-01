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
    /// 取款通知经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLNTDRAW : RqBase<RS_DLNTDRAW>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLNTDRAW"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 活期账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 通知账号 char(19)，由通知存款查询返回
        /// </summary>
        [XmlElement("notifyAccNo")]
        public string NotifyAccNo { get; set; }
        /// <summary>
        /// 通知日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime NotifyDate { get; set; }
        /// <summary>
        /// 通知日期 char(8) 格式YYYYMMDD, 对应<see cref="NotifyDate"/>
        /// </summary>
        [XmlElement("notifyDate")]
        public string NotifyDateStr
        {
            get
            {
                return this.NotifyDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NotifyDate = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额 decimal（15，2）
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 备注 varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
