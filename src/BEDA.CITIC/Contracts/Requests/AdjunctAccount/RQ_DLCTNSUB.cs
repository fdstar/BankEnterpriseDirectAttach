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
    /// 附属账户支付转账请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCTNSUB : RqBase<RS_DLCTNSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCTNSUB"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 主体账号 char(19)
        /// </summary>
        [XmlElement("mainAccNo")]
        public string MainAccNo { get; set; }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 收款账号 char(32) ，当支付方式为00(汇票)时，收款账号可空
        /// </summary>
        [XmlElement("recvAccNo")]
        public string RecvAccNo { get; set; }
        /// <summary>
        /// 收款方名称 varchar(122)
        /// </summary>
        [XmlElement("recvAccNm")]
        public string RecvAccNm { get; set; }
        /// <summary>
        /// 收款账户开户行名 varchar(122) 可空
        /// 收款账户开户行名与收款方支付联行号至少输一项
        /// </summary>
        [XmlElement("mngNode")]
        public string MngNode { get; set; }
        /// <summary>
        /// 收款方支付联行号 varchar(20) 可空
        /// 收款账户开户行名与收款方支付联行号至少输一项
        /// </summary>
        [XmlElement("tgfi")]
        public string Tgfi { get; set; }
        /// <summary>
        /// 本行他行标示 0：本行；1：他行 char(1)
        /// </summary>
        [XmlElement("sameBank")]
        public int SameBank { get; set; }
        /// <summary>
        /// 支付方式 00：汇票；01：系统内转账；02：大额；03：小额；04同城票交；05：网银跨行支付char(2)
        /// </summary>
        [XmlElement("tranType")]
        public string TranType { get; set; }
        /// <summary>
        /// 收款账户的开户行行号varchar(20)，可空，支付方式为05网银跨行支付时必输
        /// </summary>
        [XmlElement("recvTgfi")]
        public string RecvTgfi { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 取票人证件号码 汇票填写 varchar(30)支付方式为汇票时非空
        /// </summary>
        [XmlElement("certNo")]
        public string CertNo { get; set; }
        /// <summary>
        /// 取票人证件类型 汇票填写 char(1)支付方式为汇票时非空，见附录4.1
        /// </summary>
        [XmlElement("certType")]
        public string CertType { get; set; }
        /// <summary>
        /// 取票人姓名 汇票填写 varchar(20) 非空
        /// </summary>
        [XmlElement("prsNm")]
        public string PrsNm { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约；1：预约char(1)
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
        /// 摘要，可空 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
