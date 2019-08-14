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
    /// 票据库交易状态同步请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBADSTK : RqBase<RS_DLBADSTK>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBADSTK"; set { } }
        /// <summary>
        /// 客户流水号varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 需同步交易的请求代码char(8)，值域见附录4.10 
        /// </summary>
        [XmlElement("reqCode")]
        public string ReqCode { get; set; }
    }
}
