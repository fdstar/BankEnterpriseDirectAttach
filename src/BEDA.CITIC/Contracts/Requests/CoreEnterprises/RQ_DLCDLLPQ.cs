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
    /// 融资详情查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCDLLPQ : RqBase<RS_DLCDLLPQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCDLLPQ"; set { } }
        /// <summary>
        /// SCF放款批次号，SCF放款审批通过后，通过B2C通知发送给企业端 varchar(15)
        /// </summary>
        [XmlElement("scfTxNo")]
        public string ScfTxNo { get; set; }
    }
}
