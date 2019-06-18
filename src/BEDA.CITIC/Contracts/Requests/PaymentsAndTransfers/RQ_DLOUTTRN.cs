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
    /// 对外支付请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLOUTTRN : RqBase<RS_DLOUTTRN>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLOUTTRN"; set { } }
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
        /// 延期支付时间char(6)  格式hhmmss，只限100000，120000，140000，160000 四个时间点，预约时非空
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
        /// 支付方式 00：汇票； 01：中信内部转账；02：大额支付；03：小额支付；04：同城票交；05：网银跨行支付；B5：大额夜间支付 char(2)
        /// </summary>
        [XmlElement("payType")]
        public string PayType { get; set; }
        /// <summary>
        /// 收款人所属银行行号 varchar(20)，可空，支付方式为05(网银跨行支付)时非空
        /// </summary>
        [XmlElement("recBankNo")]
        public string RecBankNo { get; set; }
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
        /// 收款账户开户行名(全称) varchar(122)
        /// 当支付方式payType不为05(网银跨行支付)时，其中收款账号开户行名与收款账号开户行联行网点号至少输一项
        /// </summary>
        [XmlElement("recOpenBankName")]
        public string RecOpenBankName { get; set; }
        /// <summary>
        /// 收款账户开户行联行网点号 varchar(20)
        /// 当支付方式payType不为05(网银跨行支付)时，其中收款账号开户行名与收款账号开户行联行网点号至少输一项
        /// </summary>
        [XmlElement("recOpenBankCode")]
        public string RecOpenBankCode { get; set; }
        /// <summary>
        /// 中信标志 0：中信；1：他行 char(1)
        /// </summary>
        [XmlElement("citicbankFlag")]
        public int CiticbankFlag { get; set; }
        /// <summary>
        /// 同城标志 0：同城；1：异地 char(1) 中信内转账可空
        /// </summary>
        [XmlElement("cityFlag")]
        public string CityFlag { get; set; }
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
        /// <summary>
        /// 备注 varchar(60) 可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
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
        /// 对账编号char(20)，标签可空
        /// </summary>
        [XmlElement("chkNum")]
        public string ChkNum { get; set; }
    }
}
