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
    /// 收款单位下载请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLRECEXP : RqBase<RS_DLRECEXP>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLRECEXP"; set { } }
    }
}
