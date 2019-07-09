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
    /// 收款单位分组查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLRGPQRY : RqBase<RS_DLRGPQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLRGPQRY"; set { } }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccount")]
        public string PayAccount { get; set; }
    }
}
