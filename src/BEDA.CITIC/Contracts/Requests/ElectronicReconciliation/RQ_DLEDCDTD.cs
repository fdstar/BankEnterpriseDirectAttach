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
    /// 电子回单下载请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLEDCDTD : RqBase<RS_DLEDCDTD>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLEDCDTD"; set { } }
        /// <summary>
        /// 银行号varchar (3)，可空
        /// </summary>
        [XmlElement("bankId")]
        public string BankId { get; set; }
        /// <summary>
        /// 是否为T+0 日varchar (1)， 1：是；2：否
        /// </summary>
        [XmlElement("isCurrDay")]
        public int IsCurrDay { get; set; }
        /// <summary>
        /// 账号varchar(19)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<ReconciliationQuery> Collection { get; set; }
    }
    /// <summary>
    /// 电子回单下载
    /// </summary>
    public class ReconciliationQuery
    {
        /// <summary>
        /// 回单编号varchar (28)
        /// </summary>
        [XmlElement("brSeqNo")]
        public string BrSeqNo { get; set; }
        /// <summary>
        /// 回单类型varchar (6)，100000：存款回单；100001：取款回单；200000：转账回单；200001：缴税回单；300000：收费回单；400000定期回单；400001：活期回单
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
    }
}
