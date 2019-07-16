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
    /// 白名单经办(删除)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBFJUDL : RqBase<RS_DLBFJUDL>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBFJUDL"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 收款人账号 char(19)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }
    }
}
