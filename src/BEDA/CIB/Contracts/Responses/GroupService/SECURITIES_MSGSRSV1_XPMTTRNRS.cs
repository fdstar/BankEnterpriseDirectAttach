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
    public class SECURITIES_MSGSRSV1_XPMTTRNRS : IResponse
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
        /// 网银系统跟踪号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string SRVRTID { get; set; }
        /// <summary>
        /// 集团中心账户信息  (兴业银行账户) 必回
        /// </summary>
        [XmlElement(Order = 3)]
        public Requests.RQBODY FUNDACCT { get; set; }
        /// <summary>
        /// 转账信息节点	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public XFERINFO XFERINFO { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 5)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
