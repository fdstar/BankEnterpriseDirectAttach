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
    /// 3.8.4理财产品说明书及协议查询请求主体
    /// </summary>
    public class V1_FPAGMTTRNRQ : IRequest<V1_FPAGMTTRNRS>
    {
        /// <summary>
        /// 3.8.4理财产品说明书及协议查询请求主体
        /// </summary>
        public FPAGMTTRNRQ FPAGMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.4理财产品说明书及协议查询请求主体
    /// </summary>
    public class FPAGMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.4理财产品说明书及协议查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FPAGMTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.8.4理财产品说明书及协议查询请求内容
    /// </summary>
    public class FPAGMTTRN_RQBODY
    {
        /// <summary>
        /// 产品代码，8位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string PRODNO { get; set; }
    }
}
