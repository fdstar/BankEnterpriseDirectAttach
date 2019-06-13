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
    /// 交易状态查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCIDSTT : RqBase<RS_DLCIDSTT>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCIDSTT"; set { } }
        /// <summary>
        /// 客户流水号char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 原请求代码char(8)，可空，若客户能保证各类型的流水号都统一编号，则可空，否则需上送原请求代码，交易请求码列表见附录4.5
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
