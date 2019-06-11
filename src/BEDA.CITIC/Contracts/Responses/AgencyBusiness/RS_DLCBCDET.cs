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
    /// 跨行收款-明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCBCDET : RsBase
    {
        /// <summary>
        /// 成功总笔数 int
        /// </summary>
        [XmlElement("succNum")]
        public int SuccNum { get; set; }
        /// <summary>
        /// 成功总金额decimal(15,2)
        /// </summary>
        [XmlElement("succAmount")]
        public decimal SuccAmount { get; set; }
        /// <summary>
        /// 失败总笔数int
        /// </summary>
        [XmlElement("failNum")]
        public int FailNum { get; set; }
        /// <summary>
        /// 失败总金额decimal(15,2)
        /// </summary>
        [XmlElement("failAmount")]
        public decimal FailAmount { get; set; }
        /// <summary>
        /// 收款账号char(19)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<AgencyResult> List { get; set; }
    }
    /// <summary>
    /// 跨行收款-明细
    /// </summary>
    public class CrossBankReceiptResult
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
        /// 币种 varchar(3)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 用途 varchar(102)
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }
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
    }
}
