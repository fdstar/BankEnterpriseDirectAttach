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
    /// 解除质押通知请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCDUINQ : RqBase<RS_DLCDUINQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCDUINQ"; set { } }
        /// <summary>
        /// 解除质押通知书编号 varchar(20), SCF系统通过B2C的通知编号推送交易发送给企业端
        /// </summary>
        [XmlElement("rlsmgntcNo")]
        public string RlsmgntcNo { get; set; }
    }
}
