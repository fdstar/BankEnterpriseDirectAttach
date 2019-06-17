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
    /// 现金池信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLPOOLQY : RqBase<RS_DLPOOLQY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLPOOLQY"; set { } }
    }
}
