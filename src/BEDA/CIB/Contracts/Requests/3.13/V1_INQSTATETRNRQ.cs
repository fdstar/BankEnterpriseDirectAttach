using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.13.6支付指令核心处理结果查询请求主体
    /// </summary>
    public class V1_INQSTATETRNRQ : IRequest<V1_INQSTATETRNRS>
    {
        /// <summary>
        /// 3.13.6支付指令核心处理结果查询请求主体
        /// </summary>
        public INQSTATETRNRQ INQSTATETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.13.6支付指令核心处理结果查询请求主体
    /// </summary>
    public class INQSTATETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 查询条件	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public INQSTATECOND INQSTATECOND { get; set; }
    }
    /// <summary>
    /// 3.13.6支付指令核心处理结果查询条件
    /// </summary>
    public class INQSTATECOND
    {
        /// <summary>
        /// 网银跟踪号  两者选一必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 客户指令识别码  两者选一必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLIENTREF { get; set; }
    }
}
