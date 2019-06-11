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
    /// 跨行收款-经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCBCSUB : RqBase<RS_DLCBCSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCBCSUB"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 收款账号char(19)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 总笔数  必须为数字char(4)
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get { return this.Collection?.List?.Count ?? 0; } set { } }
        /// <summary>
        /// 总金额 deciam(15,2)
        /// </summary>
        [XmlElement("totalAmount")]
        public decimal TotalAmount { get { return this.Collection?.List?.Sum(x => x.TranAmount) ?? 0; } set { } }
        /// <summary>
        /// 摘要，可空 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<CrossBankReceipt> Collection { get; set; }
    }
    /// <summary>
    /// 跨行收款
    /// </summary>
    public class CrossBankReceipt
    {
        /// <summary>
        /// 交易序号int(4)
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 付款账号 char(32)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 付款账号名称 varchar(122)
        /// </summary>
        [XmlElement("payAccountName")]
        public string PayAccountName { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 币种 varchar(3)，仅支持人民币
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 开户银行号varchar(4)，参见附录4.9
        /// </summary>
        [XmlElement("openBankNo")]
        public string OpenBankNo { get; set; }
        /// <summary>
        /// 用途 varchar(102)， 可空
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }
        /// <summary>
        /// 付款账户类型10：借记卡；20：贷记卡； 30：存折 char(2)
        /// </summary>
        [XmlElement("payAccType")]
        public string PayAccType { get; set; }
        /// <summary>
        /// 支付方式证件类型 char(2)，参见附录4.10
        /// </summary>
        [XmlElement("certType")]
        public string CertType { get; set; }
        /// <summary>
        /// 证件号码varchar(32)
        /// </summary>
        [XmlElement("certNo")]
        public string CertNo { get; set; }
    }
}
