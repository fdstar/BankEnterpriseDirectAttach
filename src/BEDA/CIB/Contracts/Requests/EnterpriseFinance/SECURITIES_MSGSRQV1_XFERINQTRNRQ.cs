using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 付款查询交易请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_XFERINQTRNRQ : IRequest<SECURITIES_MSGSRSV1_XFERINQTRNRS>
    {
        /// <summary>
        /// 付款查询请求交易
        /// </summary>
        public XFERINQTRNRQ XFERINQTRNRQ { get; set; }
    }
    /// <summary>
    /// 付款查询请求交易
    /// </summary>
    public class XFERINQTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 指令查询请求
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERINQRQ XFERINQRQ { get; set; }
    }
    /// <summary>
    /// 指令查询请求
    /// </summary>
    public class XFERINQRQ
    {
        /// <summary>
        /// 各类支付请求报文中的客户方交易流水号TRNUID，如果发送支付请求报文时控制该值唯一，则此处能够查询到唯一指令记录，最大30位	必输
        /// </summary>
        public string CLIENTREF { get; set; }
    }
}
