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
    /// 通知型智能存款账户余额查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFITTBQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<NoticeTypeAIDepositBalance> List { get; set; }
    }
    /// <summary>
    /// 通知型智能存款账户余额
    /// </summary>
    public class NoticeTypeAIDepositBalance
    {
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 业务冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("bsnFrzAmt")]
        public decimal BsnFrzAmt { get; set; }
        /// <summary>
        /// 司法冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("lawFrzAmt")]
        public decimal LawFrzAmt { get; set; }
        /// <summary>
        /// 可用余额decimal(15,2)
        /// </summary>
        [XmlElement("avlAmt")]
        public decimal AvlAmt { get; set; }
        /// <summary>
        /// 币种char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 查询状态char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 查询状态信息varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
