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
    public class V1_ICTRANSFERINQTRNRQ : IRequest<V1_ICTRANSFERINQTRNRS>
    {
        /// <summary>
        /// 快速转账支付指令查询
        /// </summary>
        public ICTRANSFERINQTRNRQ ICTRANSFERINQTRNRQ { get; set; }
    }
    /// <summary>
    /// 快速转账支付指令查询
    /// </summary>
    public class ICTRANSFERINQTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 支付指令查询请求
        /// </summary>
        [XmlElement(Order = 1)]
        public XFERINQRQ XFERINQRQ { get; set; }
    }

}
