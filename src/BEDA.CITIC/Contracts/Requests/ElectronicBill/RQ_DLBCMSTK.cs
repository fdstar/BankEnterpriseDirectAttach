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
    /// 票据状态同步请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBCMSTK : RqBase<RS_DLBCMSTK>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBCMSTK"; set { } }
        /// <summary>
        /// 需同步交易的请求代码 char(8) 见附录：4.1.1、4.1.2、4.1.3
        /// </summary>
        [XmlElement("reqCode")]
        public string ReqCode { get; set; }
        /// <summary>
        /// 客户流水号 varchar (20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
    }
}
