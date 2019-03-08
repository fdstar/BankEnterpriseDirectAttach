using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.10.5快速转账支付指令查询响应主体
    /// </summary>
    public class V1_ICTRANSFERINQTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.10.5快速转账支付指令查询响应
        /// </summary>
        public ICTRANSFERINQTRNRS ICTRANSFERINQTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.10.5快速转账支付指令查询响应
    /// </summary>
    public class ICTRANSFERINQTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.10.5响应交易处理信息节点，此处查询结果固定只有一笔
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERINQRS XFERINQRS { get; set; }
    }
}
