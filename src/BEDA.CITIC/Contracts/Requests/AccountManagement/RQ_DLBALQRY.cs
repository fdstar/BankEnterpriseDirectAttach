using BEDA.CITIC.Contracts.Responses;
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
    public class RQ_DLBALQRY : RqBase<RS_DLBALQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBALQRY"; set { } }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AccQuery> Collection { get; set; }
    }
    /// <summary>
    /// 账号信息
    /// </summary>
    public class AccQuery
    {
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
    }
}
