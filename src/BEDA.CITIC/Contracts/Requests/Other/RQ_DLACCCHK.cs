using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests.AccountManagement
{
    /// <summary>
    /// 账号名称校验请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLACCCHK : RqBase<RS_DLACCCHK>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLACCCHK"; set { } }
        /// <summary>
        /// 账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称 varchar(122)
        /// </summary>
        [XmlElement("accountName")]
        public string AccountName { get; set; }
        /// <summary>
        /// 账户类型 0：公司；1：个人 char(1)
        /// </summary>
        [XmlElement("accountType")]
        public int AccountType { get; set; }
    }
}
