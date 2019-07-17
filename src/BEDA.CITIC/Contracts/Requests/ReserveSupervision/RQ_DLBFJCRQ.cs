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
    /// 备付金信息核对结果查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBFJCRQ : RqBase<RS_DLBFJCRQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBFJCRQ"; set { } }
        /// <summary>
        /// 备付金机构编号char(20)
        /// </summary>
        [XmlElement("protocolNo")]
        public string ProtocolNo { get; set; }
    }
}
