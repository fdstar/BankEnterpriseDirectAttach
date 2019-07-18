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
    /// 定期型智能存款账户余额查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFITDBQ : RqBase<RS_DLFITDBQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFITDBQ"; set { } }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AccQuery> Collection { get; set; }
    }
}
