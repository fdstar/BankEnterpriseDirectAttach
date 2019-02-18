using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.10.3快速转账支付响应主体
    /// </summary>
    public class V1_ICTRANSFERTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.10.3快速转账支付响应
        /// </summary>
        public ICTRANSFERTRNRS ICTRANSFERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.10.3快速转账支付响应
    /// </summary>
    public class ICTRANSFERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.10.3响应交易处理信息节点
        /// </summary>
        [XmlElement(Order = 2)]
        public XPMTRS XPMTRS { get; set; }
    }
    /// <summary>
    /// 响应交易处理信息节点
    /// </summary>
    public class XPMTRS : Requests.XMPTRQ<Requests.RQACCT>
    {
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
