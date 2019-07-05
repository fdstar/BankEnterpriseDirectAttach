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
    /// 应付账单经办查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLOWPYQY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<PayableBill> List { get; set; }
    }
    /// <summary>
    /// 应付账单经办
    /// </summary>
    public class PayableBill
    {
        /// <summary>
        /// 批次号 varchar(8)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 账单流水号 char(20)
        /// </summary>
        [XmlElement("payOrderNo")]
        public string PayOrderNo { get; set; }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccNo")]
        public string PayAccNo { get; set; }
        /// <summary>
        /// 收款账号 char(19)
        /// </summary>
        [XmlElement("rcvAccNo")]
        public string RcvAccNo { get; set; }
        /// <summary>
        /// 收款账户名称 varchar(122)
        /// </summary>
        [XmlElement("rcvAccNm")]
        public string RcvAccNm { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 摘要 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
    }
}
