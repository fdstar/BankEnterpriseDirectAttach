using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 余额查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBALQRY : RqBase<AccountQuery>
    {
    }
    /// <summary>
    /// 账号信息
    /// </summary>
    public class AccountQuery
    {
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
    }
}
