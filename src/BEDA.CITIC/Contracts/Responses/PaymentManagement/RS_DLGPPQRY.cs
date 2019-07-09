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
    /// 收款单位分组前查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLGPPQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<PayeeGroupPrevQuery> List { get; set; }
    }
    /// <summary>
    /// 收款单位分组前
    /// </summary>
    public class PayeeGroupPrevQuery
    {
        /// <summary>
        /// 付款账户名称varchar (122)
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 付款账号varchar (19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 是否已分组标识char(1) ，0：未分组；1：已分组
        /// </summary>
        [XmlElement("groupFlag")]
        public int GroupFlag { get; set; }
    }
}
