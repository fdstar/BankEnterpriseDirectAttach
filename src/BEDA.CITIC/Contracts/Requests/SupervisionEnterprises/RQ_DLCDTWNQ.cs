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
    /// 移库通知请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCDTWNQ : RqBase<RS_DLCDTWNQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCDTWNQ"; set { } }
        /// <summary>
        /// 移库通知编号 varchar(12)， SCF系统通过B2C的通知编号推送交易发送给企业端
        /// </summary>
        [XmlElement("mwntcNo")]
        public string MwntcNo { get; set; }
    }
}
