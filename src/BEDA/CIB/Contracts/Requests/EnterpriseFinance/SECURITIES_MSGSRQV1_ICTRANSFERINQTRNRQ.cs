using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 快速转账支付指令查询请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_ICTRANSFERINQTRNRQ : IRequest<SECURITIES_MSGSRSV1_ICTRANSFERINQTRNRS>
    {
        /// <summary>
        /// 快速转账支付指令查询
        /// </summary>
        public ICTRANSFERINQTRNRQ ICTRANSFERINQTRNRQ { get; set; }
    }
    /// <summary>
    /// 快速转账支付指令查询
    /// </summary>
    public class ICTRANSFERINQTRNRQ
    {
        /// <summary>
        /// 客户端交易的唯一标志，否则客户端将无法分辨响应报文的对应关系,最大30位,建议值为YYYYMMDD+序号 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string TRNUID { get; set; }
        /// <summary>
        /// 支付指令查询请求
        /// </summary>
        [XmlElement(Order = 1)]
        public XFERINQRQ XFERINQRQ { get; set; }
    }

}
