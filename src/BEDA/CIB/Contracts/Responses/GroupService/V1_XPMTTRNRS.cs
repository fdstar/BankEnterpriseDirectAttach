using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 集团支付响应主体
    /// </summary>
    public class V1_XPMTTRNRS : IResponse
    {
        /// <summary>
        /// 集团支付响应
        /// </summary>
        public XPMTTRNRS XPMTTRNRS { get; set; }
    }
    /// <summary>
    /// 集团支付响应
    /// </summary>
    public class XPMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 响应交易处理信息节点
        /// </summary>
        [XmlElement(Order = 2)]
        public XPMTRS XPMTRS { get; set; }
    }
}
