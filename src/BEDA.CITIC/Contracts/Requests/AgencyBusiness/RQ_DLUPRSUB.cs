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
    /// 银联对私付款经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLUPRSUB : RqBase<RS_DLUPRSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLUPRSUB"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
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
        /// 摘要 varchar(60)，可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<PrivatePayment> Collection { get; set; }
    }
    /// <summary>
    /// 银联对私付款经办
    /// </summary>
    public class PrivatePayment
    {
        /// <summary>
        /// 交易序号 int(5)
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 收款账号，varchar(19)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 收款账户名称 varchar(122)
        /// </summary>
        [XmlElement("recAccountName")]
        public string RecAccountName { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 摘要，可空 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 预留字段1 varchar(30)，可空
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 预留字段2 varchar(30)，可空
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 预留字段3 varchar(30)，可空
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
    }
}
