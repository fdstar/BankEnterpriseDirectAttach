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
    /// 定期型智能存款明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFITDDQ : RsBase
    {
        /// <summary>
        /// 活期账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 活期账户名称varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 账户余额decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("frzAmt")]
        public decimal FrzAmt { get; set; }
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
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AIDepositDetail> List { get; set; }
    }
}
