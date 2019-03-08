using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.1转账对应请求的响应主体
    /// </summary>
    public class V1_XFERTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.1转账对应请求的响应，可能包括同步的内容
        /// </summary>
        public XFERTRNRS XFERTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.1转账对应请求的响应，可能包括同步的内容
    /// </summary>
    public class XFERTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.4.1转账付出指令内容
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERRS XFERRS { get; set; }
    }
    /// <summary>
    /// 3.4.1转账付出指令内容
    /// </summary>
    public class XFERRS
    {
        /// <summary>
        /// 服务器该笔交易的唯一标识	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 转账信息	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public XFERINFO XFERINFO { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
        /// <summary>
        /// 客户端转账流水号，最长30位
        /// </summary>
        [XmlElement(Order = 3)]
        public string CLIENTREF { get; set; }
    }
}
