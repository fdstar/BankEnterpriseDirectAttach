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
    /// 接收方签收信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBCMQSQ : RqBase<RS_DLBCMQSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBCMQSQ"; set { } }
        /// <summary>
        /// 客户流水号 varchar (20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 申请交易对应请求代码 char(8) 见附录4.1.1
        /// </summary>
        [XmlElement("reqCode")]
        public string ReqCode { get; set; }
    }
}
