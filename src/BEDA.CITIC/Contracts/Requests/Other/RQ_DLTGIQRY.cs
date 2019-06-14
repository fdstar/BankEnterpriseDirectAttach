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
    /// 大额夜间支付联行信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLTGIQRY : RqBase<RS_DLTGIQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLTGIQRY"; set { } }
        /// <summary>
        /// 支付联行号varchar(20) ，可空
        /// </summary>
        [XmlElement("tgfi")]
        public string Tgfi { get; set; }
        /// <summary>
        /// 支付联行名称varchar(122) ，可空，支持模糊查询
        /// </summary>
        [XmlElement("tgname")]
        public string Tgname { get; set; }
    }
}
