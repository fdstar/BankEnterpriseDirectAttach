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
    /// 代理扣收企业款明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLAGEPDT : RsBase
    {
        /// <summary>
        /// 收款账号 varchar(19)
        /// </summary>
        [XmlElement("rcvAccountNo")]
        public string RcvAccountNo { get; set; }
        /// <summary>
        /// 总记录条数 int
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }
        /// <summary>
        /// 备注varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<WithholdEnterpriseResult> List { get; set; }
    }
    /// <summary>
    /// 代理扣收企业款明细
    /// </summary>
    public class WithholdEnterpriseResult : Requests.WithholdFunds
    {
        /// <summary>
        /// 付款账号开户行名称 varchar(122)
        /// </summary>
        [XmlElement("payAccBankNm")]
        public string PayAccBankNm { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
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
