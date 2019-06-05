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
    /// 财务报销请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLEXPENS : RqBase<RS_DLEXPENS>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLEXPENS"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约交易；1：预约交易 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 延期支付时间，预约时非空，时间点可选范围 100000，120000，140000，160000
        /// </summary>
        [XmlIgnore]
        public DateTime? DeferredPaymentTime { get; set; }
        /// <summary>
        /// 延期支付日期char(8)　格式YYYYMMDD ，预约时非空
        /// </summary>
        [XmlElement("preDate")]
        public string PreDateStr
        {
            get
            {
                return this.DeferredPaymentTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 延期支付时间char(6)  格式hhmmss，只限100000，120000，140000，160000 四个时间点，预约时非空
        /// </summary>
        [XmlElement("preTime")]
        public string PreTimeStr
        {
            get
            {
                return this.DeferredPaymentTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 收款账号 char(32)，当支付方式为00(汇票)时，收款账号可空
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 收款账户名称 varchar(122)
        /// </summary>
        [XmlElement("recAccountName")]
        public string RecAccountName { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要，可空 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
