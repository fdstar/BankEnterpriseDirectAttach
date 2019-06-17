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
    /// 成员单位可用资金查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_CMMACQRY : RqBase<RS_CMMACQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "CMMACQRY"; set { } }
        /// <summary>
        /// 核心账号char(19)，当成员单位只归属于一个现金池时，核心账号可为空
        /// </summary>
        [XmlElement("coreAccountNo")]
        public string CoreAccountNo { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AccQuery> Collection { get; set; }
    }
}
