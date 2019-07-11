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
    /// 保证金账户开立经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLDPTSUB : RqBase<RS_DLDPTSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLDPTSUB"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 活期账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 保证金账号char(19)，可空，当保证金属性为0(活期)时有效
        /// </summary>
        [XmlElement("depositAccNo")]
        public string DepositAccNo { get; set; }
        /// <summary>
        /// 交易金额decimal(15,2)，当保证金属性为1(定期)时，交易金额不能小于10000.00元
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
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
        /// <summary>
        /// 保证金属性char(1)，0：活期；1：定期
        /// </summary>
        [XmlElement("depositAttr")]
        public int DepositAttr { get; set; }
        /// <summary>
        /// 保证金账户类型char(1)，1：银行承兑汇票保证金；2：保函保证金；3：信用证保证金；4：其他
        /// </summary>
        [XmlElement("depositType")]
        public int DepositType { get; set; }
        /// <summary>
        /// 存期char(3)，可空，保证金属性为1(定期)时非空，格式M03：三个月；M06：六个月；Y01：一年；Y02：两年
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }
    }
}
