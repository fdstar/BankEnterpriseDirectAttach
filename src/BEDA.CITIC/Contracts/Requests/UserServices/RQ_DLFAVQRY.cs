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
    /// 优惠费率查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFAVQRY : RqBase<RS_DLFAVQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFAVQRY"; set { } }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
    }
}
