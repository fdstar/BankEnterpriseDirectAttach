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
    /// 银联对私付款明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLUPRDET : RsBase
    {
        /// <summary>
        /// 成功总笔数 int(4)
        /// </summary>
        [XmlElement("succNum")]
        public int SuccNum { get; set; }
        /// <summary>
        /// 成功总金额 decimal(15,2)
        /// </summary>
        [XmlElement("succAmount")]
        public decimal SuccAmount { get; set; }
        /// <summary>
        /// 失败总笔数 int(4)
        /// </summary>
        [XmlElement("failNum")]
        public int FailNum { get; set; }
        /// <summary>
        /// 失败总金额 decimal(15,2)
        /// </summary>
        [XmlElement("failAmount")]
        public decimal FailAmount { get; set; }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 摘要 varchar(60)
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
    /// 银联对私付款明细查询
    /// </summary>
    public class PrivatePaymentResult : Requests.PrivatePayment
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
    }
}
