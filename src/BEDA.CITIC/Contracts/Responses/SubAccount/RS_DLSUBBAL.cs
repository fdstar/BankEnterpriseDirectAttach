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
    /// 附属账户余额查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSUBBAL : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SubAccountBalance> List { get; set; }
    }
    /// <summary>
    /// 附属账户余额
    /// </summary>
    public class SubAccountBalance
    {
        /// <summary>
        /// 交易状态 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 账户名称 varchar(122)
        /// </summary>
        [XmlElement("subAccNm")]
        public string SubAccNm { get; set; }
        /// <summary>
        /// 可用资金 decimal(15,2)
        /// </summary>
        [XmlElement("actBal")]
        public decimal ActBal { get; set; }
        /// <summary>
        /// 实际余额 decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 账户冻结金额 decimal(15,2)
        /// </summary>
        [XmlElement("frozenAmt")]
        public decimal FrozenAmt { get; set; }
        /// <summary>
        /// 透支额度 decimal(15,2)
        /// </summary>
        [XmlElement("overAmt")]
        public decimal OverAmt { get; set; }
        /// <summary>
        /// 附属账户上日余额 decimal(15,2)
        /// </summary>
        [XmlElement("yesterdayBal")]
        public decimal YesterdayBal { get; set; }
        /// <summary>
        /// 币种  char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
    }
}
