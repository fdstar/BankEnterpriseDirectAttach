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
    /// 网银互联参与机构信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLOBKQRY : RqBase<RS_DLOBKQRY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLOBKQRY"; set { } }
    }
}
