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
    /// 不归集额度设置经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCMGSUB : RqBase<RS_DLCMGSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCMGSUB"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 现金池ID  char(8) 由现金池信息查询结果获取
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 不归集金额 decimal(15,2)
        /// </summary>
        [XmlElement("noCollAmt")]
        public decimal NoCollAmt { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约交易；1：预约交易 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 延期支付时间
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 延期支付日期char(8)，预约支付时非空，格式YYYYMMDD
        /// </summary>
        [XmlElement("preDate")]
        public string PreDateStr
        {
            get
            {
                return this.AppointmentTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 延期支付时间char(6)，预约支付时非空，格式hhmmss
        /// </summary>
        [XmlElement("preTime")]
        public string PreTimeStr
        {
            get
            {
                return this.AppointmentTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 摘要 varchar(102) 可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注 varchar(60) 可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
