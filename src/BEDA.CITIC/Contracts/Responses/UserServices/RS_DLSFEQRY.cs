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
    /// 标准费率查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSFEQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<StandardRate> List { get; set; }
    }
    /// <summary>
    /// 标准费率
    /// </summary>
    public class StandardRate
    {
        /// <summary>
        /// 交易类型 varchar(2)，交易类型类型参见附录4.3
        /// </summary>
        [XmlElement("tranType")]
        public string TranType { get; set; }
        /// <summary>
        /// 本异地标志 char(1)，空值：同城及异地；0：同城；1：异地
        /// </summary>
        [XmlElement("sameAreaFlag")]
        public int SameAreaFlag { get; set; }
        /// <summary>
        /// 本他行标志 char(1)，空值：中信银行及他行，0：中信银行；1：他行
        /// </summary>
        [XmlElement("sameBank")]
        public int SameBank { get; set; }
        /// <summary>
        /// 账户所属行 char(1)，可空，客户为单一客户时有效；0：中信银行；1：他行；2：中信银行及他行
        /// </summary>
        [XmlElement("accBank")]
        public int? AccBank { get; set; }
        /// <summary>
        /// 授权机构所属行 char(1)，可空，客户为单一客户时有效；0：中信银行；1：他行；2：中信银行及他行
        /// </summary>
        [XmlElement("authorBank")]
        public int? AuthorBank { get; set; }
        /// <summary>
        /// 付款行 char(1)，可空，客户为单一客户时有效；0：中信银行；1：他行；2：中信银行及他行
        /// </summary>
        [XmlElement("payBank")]
        public int? PayBank { get; set; }
        /// <summary>
        /// 收款行 char(1)，可空，客户为单一客户时有效；0：中信银行；1：他行；2：中信银行及他行
        /// </summary>
        [XmlElement("rcvBank")]
        public int? RcvBank { get; set; }
        /// <summary>
        /// 币种 char(2) “01”为人民币
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 转账金额下限 decimal(15，2) minAmt，maxAmt同时为0时，金额范围为任意金额
        /// </summary>
        [XmlElement("minAmt")]
        public decimal MinAmt { get; set; }
        /// <summary>
        /// 转账金额上限 decimal(15，2) minAmt，maxAmt同时为0时，金额范围为任意金额
        /// </summary>
        [XmlElement("maxAmt")]
        public decimal MaxAmt { get; set; }
        /// <summary>
        /// 费率 decimal(17,4)
        /// </summary>
        [XmlElement("rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// 基本收费 decimal(15,2)
        /// </summary>
        [XmlElement("baseFee")]
        public decimal BaseFee { get; set; }
        /// <summary>
        /// 资金发生数 decimal(15,2)
        /// </summary>
        [XmlElement("amtCount")]
        public decimal AmtCount { get; set; }
        /// <summary>
        /// 收费定价方式 char(1) 1:按固定金额收费; 2:按固定比例收费; 3:按固定金额加固定比例收费
        /// </summary>
        [XmlElement("feeType")]
        public int FeeType { get; set; }
        /// <summary>
        /// 收费项目代码 varchar(9)
        /// </summary>
        [XmlElement("feeProjType")]
        public string FeeProjType { get; set; }
        /// <summary>
        /// 收费项目说明 varchar(62)
        /// </summary>
        [XmlElement("feeProjInfo")]
        public string FeeProjInfo { get; set; }
        /// <summary>
        /// 分层定价标志 char(1) 0：全额累进；1：超额累进
        /// </summary>
        [XmlElement("progFlag")]
        public int ProgFlag { get; set; }
    }
}
