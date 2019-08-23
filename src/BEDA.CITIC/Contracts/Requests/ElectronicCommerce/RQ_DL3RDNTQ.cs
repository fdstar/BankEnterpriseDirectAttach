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
    /// 订单通知查询(第三方支付)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DL3RDNTQ : RqBase<RS_DL3RDNTQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DL3RDNTQ"; set { } }
    }
    /// <summary>
    /// 订单通知查询(直联商户)请求内容
    /// </summary>
    public class RQ_DLB2CNTQ : RQ_DL3RDNTQ
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        public override string Action { get => "DLB2CNTQ"; set { } }
    }
}
