using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 批量支付明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBATDET : RsBase
    {
        /// <summary>
        /// 客户流水号char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<PayBatchDetailQry> Collection { get; set; }
    }
    /// <summary>
    /// 批量支付明细查询
    /// </summary>
    public class PayBatchDetailQry
    {
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 收款账号varchar(32)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 收款账户名称 varchar(122)
        /// </summary>
        [XmlElement("recAccountName")]
        public string RecAccountName { get; set; }
        /// <summary>
        /// 收款账户开户行联行网点号 varchar(20)
        /// </summary>
        [XmlElement("recOpenBankCode")]
        public string RecOpenBankCode { get; set; }
        /// <summary>
        /// 收款账户开户行名称varchar(122)
        /// </summary>
        [XmlElement("recOpenBankName")]
        public string RecOpenBankName { get; set; }
        /// <summary>
        /// 支付方式varchar(2)，02：大额支付；03：小额支付
        /// </summary>
        [XmlElement("payType")]
        public string PayType { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注 varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 状态代码char(7) ，值域参见见附录4.8
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 状态信息含义varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
