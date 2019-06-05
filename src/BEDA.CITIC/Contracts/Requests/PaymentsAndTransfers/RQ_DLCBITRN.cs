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
    /// 对外支付（香港账户-集团客户）请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCBITRN : RqBase<RS_DLCBITRN>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCBITRN"; set { } }
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
        /// 交易方式char(1)，1-行内转账；2-即日支付；3-海外汇款；4-普通支付
        /// </summary>
        [XmlElement("tranType")]
        public int TranType { get; set; }
        /// <summary>
        /// 收款人所属银行行号 varchar(20)，可空，支付方式为05(网银跨行支付)时非空
        /// </summary>
        [XmlElement("recBankNo")]
        public string RecBankNo { get; set; }
        /// <summary>
        /// 付款账号char(34)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 付款账户币种char(2)
        /// </summary>
        [XmlElement("payCryType")]
        public string PayCryType { get; set; }
        /// <summary>
        /// 收款账号char(34), 交易方式为行内转账时，需校验长度是12位
        /// </summary>
        [XmlElement("rcvAcc")]
        public string RcvAcc { get; set; }
        /// <summary>
        /// 收款人账户名称char(35), 交易方式为行内转账时，送空；交易方式非行内转账时，必输
        /// </summary>
        [XmlElement("rcvNm")]
        public string RcvNm { get; set; }
        /// <summary>
        /// 收款账户币种char(2) ,交易方式为行内转账时，必输；交易方式为即日支付和海外汇款和普通支付时，送空
        /// </summary>
        [XmlElement("rcvCryType")]
        public string RcvCryType { get; set; }
        /// <summary>
        /// 收款账号行号char(10), 交易方式为行内转时，必输；交易方式为即日支付和海外汇款和普通支付时，送空；交易方式为行内转账时，数据字典：CNCBIHK-信银国际香港、CNCBISG-信银国际新加坡
        /// </summary>
        [XmlElement("rcvBankNo")]
        public string RcvBankNo { get; set; }
        /// <summary>
        /// 交易金额 decimal（15,2）
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 交易币种char(2), 交易方式为行内转账时，交易币种必须等同于付款账户或收款账户币种；交易方式为即日支付时，1)如果收款人国家代号为香港，交易币种限于：HKD/CNY/EUR/USD；2)如果收款人国家代号为深圳，交易币种限于：HKD；交易方式为海外汇款时，限于13个币种：29-AUD、28-CAD、15-CHF、01-CNY、51-EUR、12-GBP、13-HKD、27-JPY、32-NOK、62-NZD、21-SEK、18-SGD、14-USD；交易方式为普通支付时，只限于13-HKD/01-CNY，必须等于付款账户币种
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 费用扣除方式 char(3), 交易方式为行内转账和普通支付时，送空；交易方式为即日支付和海外汇款时，必输；数据字典：OUR-付款人支付、BEN-收款人支付、SHA-对半分担
        /// </summary>
        [XmlElement("feeType")]
        public string FeeType { get; set; }
        /// <summary>
        /// 客户摘要char(102),可空
        /// </summary>
        [XmlElement("rem")]
        public string Rem { get; set; }
        /// <summary>
        /// 汇率合约号char(16),可空
        /// </summary>
        [XmlElement("excratecNo")]
        public string ExcratecNo { get; set; }
        /// <summary>
        /// 收款人地址char(70)，交易方式为普通支付、海外汇款和即日支付时，选输；交易方式为行内转账时，送空；交易方式为海外汇款及收款人国家代号为(CA)加拿大的海外汇款必须提供收款地址
        /// </summary>
        [XmlElement("rcvAddress")]
        public string RcvAddress { get; set; }
        /// <summary>
        /// 收款人国家代号char(35), 交易方式为行内转账时，送空；交易方式为即日支付时，至少必需填写收款人国家代号，只限于HK香港，CN中国深圳；交易方式为海外汇款时，必输并且必须在指定的范围之内；如果收款人国家代号为加拿大时，收款人地址不能为空。交易方式为普通转账时，收款人国家代号必输，只限于HK香港
        /// </summary>
        [XmlElement("rCountryCode")]
        public string RCountryCode { get; set; }
        /// <summary>
        /// 收款人电子邮件char(200), 交易方式为行内转账时，送空；交易方式为普通支付、即日支付和海外汇款时，选输
        /// </summary>
        [XmlElement("rcvEmail")]
        public string RcvEmail { get; set; }
        /// <summary>
        /// 收款人银行代号char(12), 交易方式为行内转账时，送空；交易方式为海外汇款时，选输，银行的SWIFT代号; 交易方式为即日支付时，必输，根据银行的SWIFT代号；交易方式为普通支付时，必输，根据香港清算局本地银行代码表HKICL Bank Code; 交易方式为海外汇款时，收款人银行代号或收款人银行名称+收款人银行地址+收款人银行国家代号，必输其一组
        /// </summary>
        [XmlElement("rbankCode")]
        public string RbankCode { get; set; }
        /// <summary>
        /// 收款人银行名称char(35), 交易方式为行内转账、普通支付时，送空；交易方式为即日支付和海外汇款时，选输; 交易方式为海外汇款时，收款人银行代号或收款人银行名称+收款人银行地址+收款人银行国家代号，必输其一组
        /// </summary>
        [XmlElement("rcvBankNm")]
        public string RcvBankNm { get; set; }
        /// <summary>
        /// 收款人银行分支行代号char(12), 交易方式为行内转账、即日支付和海外汇款时，送空；交易方式为普通支付时，选输
        /// </summary>
        [XmlElement("rcvBranchNo")]
        public string RcvBranchNo { get; set; }
        /// <summary>
        /// 收款人银行地址char(70), 交易方式为行内转账、普通支付时，送空；交易方式为海外汇款、即日支付时，选输; 交易方式为海外汇款时，收款人银行代号或收款人银行名称+收款人银行地址+收款人银行国家代号，必输其一组
        /// </summary>
        [XmlElement("rBankAdd")]
        public string RBankAdd { get; set; }
        /// <summary>
        /// 收款人银行国家代号char(35), 交易方式为行内转账时，送空; 交易方式为即日支付、普通支付时，必输；交易方式为即日支付时，收款人银行国家代号必须为HK或者CN;交易方式为普通支付时，收款人银行国家代号必须为HK； 交易方式为海外汇款时，收款人银行代号或收款人银行名称+收款人银行地址+收款人银行国家代号，必输其一组
        /// </summary>
        [XmlElement("rcvBankCCode")]
        public string RcvBankCCode { get; set; }
        /// <summary>
        /// 附言char(140), 交易方式为行内转账时，送空；交易方式为普通支付、即日支付和海外汇款时，选输; 交易方式为海外汇款时，所有从境外支付到中国内地的人民币海外汇款必须提供支付用途说明（CCTFDR-资本项下跨境支付、CCDNDR-慈善捐款、CGODDR-货物贸易、COCADR-其他经常项目、CSTRDR-服务贸易）
        /// </summary>
        [XmlElement("postscript")]
        public string Postscript { get; set; }
        /// <summary>
        /// 支付用途代号char(2), 交易方式为行内转账、即日支付和海外汇款时，送空；交易方式为普通支付时，必输; 交易方式为普通支付时，数据字典：20：Sundry Credit、22：Salary Credit、23：Dividend Credit
        /// </summary>
        [XmlElement("payUseNo")]
        public string PayUseNo { get; set; }
        /// <summary>
        /// 中介银行代号char(12), 交易方式为行内转账、即日支付和普通支付时，送空；交易方式为海外汇款时，选输
        /// </summary>
        [XmlElement("interBankCode")]
        public string InterBankCode { get; set; }
        /// <summary>
        /// 中介银行名称char(35), 交易方式为行内转账、即日支付和普通支付时，送空；交易方式为海外汇款时，选输
        /// </summary>
        [XmlElement("interBankNm")]
        public string InterBankNm { get; set; }
        /// <summary>
        /// 中介银行地址char(70)，交易方式为行内转账、即日支付和普通支付时，送空；交易方式为海外汇款时，选输
        /// </summary>
        [XmlElement("interBank")]
        public string InterBank { get; set; }
        /// <summary>
        /// 中介银行国家代号char(35), 交易方式为行内转账、即日支付和普通支付时，送空；交易方式为海外汇款时，选输
        /// </summary>
        [XmlElement("inteCCode")]
        public string InteCCode { get; set; }
    }
}
