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
    /// 第三方商户提现明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DL3RTXDT : RqBase<RS_DL3RTXDT>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DL3RTXDT"; set { } }

        /// <summary>
        /// 批次号 varchar(8)，可空 批次号和客户流水号两者必输一项
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 客户流水号 varchar(20)，可空 批次号和客户流水号两者必输一项
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
    }
}
