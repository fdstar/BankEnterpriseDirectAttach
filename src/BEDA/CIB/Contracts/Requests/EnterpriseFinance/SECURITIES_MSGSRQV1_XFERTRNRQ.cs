using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 转账服务请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_XFERTRNRQ : IRequest<SECURITIES_MSGSRSV1_XFERTRNRS>
    {
        /// <summary>
        /// 转账服务请求
        /// </summary>
        public XFERTRNRQ XFERTRNRQ { get; set; }
    }
    /// <summary>
    /// 转账服务请求
    /// </summary>
    public class XFERTRNRQ
    {
        /// <summary>
        /// 客户端交易的唯一标志，否则客户端将无法分辨响应报文的对应关系,最大30位,建议值为YYYYMMDD+序号 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string TRNUID { get; set; }
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 生成转账付出指令内容
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERRQ XFERRQ { get; set; }
    }
    /// <summary>
    /// 生成转账付出指令内容
    /// </summary>
    public class XFERRQ
    {
        /// <summary>
        /// 转账信息
        /// </summary>
        public XFERINFO XFERINFO { get; set; }
    }
}
