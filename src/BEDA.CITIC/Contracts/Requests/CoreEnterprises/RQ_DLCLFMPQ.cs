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
    /// 放款通知详情查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCLFMPQ : RqBase<RS_DLCLFMPQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCLFMPQ"; set { } }
        /// <summary>
        /// 通知书编号 ，银行端核心系统放款成功后，通过B2C通知发送给企业端varchar (30)
        /// </summary>
        [XmlElement("ntcNo")]
        public string NtcNo { get; set; }
    }
}
