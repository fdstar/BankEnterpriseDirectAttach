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
    /// 查询收款单位响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLRECQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<PayeeInfo> List { get; set; }
    }
    /// <summary>
    /// 收款单位
    /// </summary>
    public class PayeeInfo
    {
        /// <summary>
        /// 账户名称varchar (122)
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 账号varchar (32)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户类型char(1)，0：公司；1：个人
        /// </summary>
        [XmlElement("accountType")]
        public int AccountType { get; set; }
        /// <summary>
        /// 中信标识char(1)，0：中信；1：他行
        /// </summary>
        [XmlElement("citicbankFlag")]
        public int CiticbankFlag { get; set; }
        /// <summary>
        /// 货币代码char(2)
        /// </summary>
        [XmlElement("currencyID")]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 开户行名称varchar (122)
        /// </summary>
        [XmlElement("openBankName")]
        public string OpenBankName { get; set; }
        /// <summary>
        /// 开户行联行网点号varchar (20)
        /// </summary>
        [XmlElement("openBankCode")]
        public string OpenBankCode { get; set; }
    }
}
