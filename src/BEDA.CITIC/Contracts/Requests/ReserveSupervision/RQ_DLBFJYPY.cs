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
    /// 预付卡备付金支付经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBFJYPY : RqBase<RS_DLBFJYPY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBFJYPY"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 支付方式 00：汇票； 01：中信内部转账；02：大额支付；03：小额支付；04：同城票交；05：网银跨行支付 char(2)
        /// </summary>
        [XmlElement("payType")]
        public string PayType { get; set; }
        /// <summary>
        /// 预约支付标志char(1)， 0：非预约交易；1：预约交易
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 延期支付时间，预约时非空
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 延期支付日期char(8)　格式YYYYMMDD ，预约时非空
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
        /// 延期支付时间char(6)  格式hhmmss，预约时非空
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
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 收款账号 char(32) ，当支付方式为00(汇票)时，收款账号可空
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 收款账户名称 varchar(122)
        /// </summary>
        [XmlElement("recAccountNm")]
        public string RecAccountNm { get; set; }
        /// <summary>
        /// 收款账户开户行 varchar(122)    当支付方式payType不为05(网银跨行支付)时，其中收款账号开户行名与收款账号开户行联行网点号至少输一项
        /// </summary>
        [XmlElement("recOpenBankName")]
        public string RecOpenBankName { get; set; }
        /// <summary>
        /// 收款账户开户行联行网点号 varchar(20)    当支付方式payType不为05(网银跨行支付)时，其中收款账号开户行名与收款账号开户行联行网点号至少输一项
        /// </summary>
        [XmlElement("recOpenBankCode")]
        public string RecOpenBankCode { get; set; }
        /// <summary>
        /// 中信标志char(1)， 0：中信；1：他行
        /// </summary>
        [XmlElement("citicbankFlag")]
        public int CiticbankFlag { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 取票人姓名，可空，当支付方式为汇票时输入 varchar(20)
        /// </summary>
        [XmlElement("takerName")]
        public string TakerName { get; set; }
        /// <summary>
        /// 取票人证件号，可空，当支付方式为汇票时输入 varchar(30)
        /// </summary>
        [XmlElement("takerID")]
        public string TakerID { get; set; }
        /// <summary>
        /// 取票人证件类型，当支付方式为汇票时输入，值域见附录4.1 char(1)
        /// </summary>
        [XmlElement("takerIDType")]
        public string TakerIDType { get; set; }
        /// <summary>
        /// 备注 varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 摘要 varchar(92)，可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
