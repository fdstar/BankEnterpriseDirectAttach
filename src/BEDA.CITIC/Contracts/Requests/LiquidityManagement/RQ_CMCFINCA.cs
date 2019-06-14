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
    /// 现金管理积数查询（当期）请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_CMCFINCA : RqBase<RS_CMCFINCA>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "CMCFINCA"; set { } }
        /// <summary>
        /// 核心账号char(19)
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
