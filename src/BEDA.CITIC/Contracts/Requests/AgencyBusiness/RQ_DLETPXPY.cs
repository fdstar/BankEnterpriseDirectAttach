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
    /// 代理支付转账请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLETPXPY : RqBase<RS_DLETPXPY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLETPXPY"; set { } }
        /// <summary>
        /// 客户流水号char(20)
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
        /// 支付方式char(2) ，23：代理行内通兑；24：代理小额支付；25：代理大额支付
        /// </summary>
        [XmlElement("payType")]
        public string PayType { get; set; }
        /// <summary>
        /// 客户内部账号varchar(30)
        /// </summary>
        [XmlElement("cstAccNo")]
        public string CstAccNo { get; set; }
        /// <summary>
        /// 客户内部账户名称varchar(122)
        /// </summary>
        [XmlElement("cstAccNm")]
        public string CstAccNm { get; set; }
        /// <summary>
        /// 付款账号char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 收款账号varchar(32)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 收款账户名称varchar(122)
        /// </summary>
        [XmlElement("recAccountNm")]
        public string RecAccountNm { get; set; }
        /// <summary>
        /// 收款账户开户行名称 varchar(122)，可空
        /// 收款账号开户行名与收款账号开户行联行网点号至少输一项
        /// </summary>
        [XmlElement("recOpenBankName")]
        public string RecOpenBankName { get; set; }
        /// <summary>
        /// 收款账户开户行联行网点号 varchar(20)，可空
        /// 收款账号开户行名与收款账号开户行联行网点号至少输一项
        /// </summary>
        [XmlElement("recOpenBankCode")]
        public string RecOpenBankCode { get; set; }
        /// <summary>
        /// 中信标志 0：中信；1：他行 char(1)
        /// </summary>
        [XmlElement("citicbankFlag")]
        public string CiticbankFlag { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要 varchar(102)，可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注 varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
