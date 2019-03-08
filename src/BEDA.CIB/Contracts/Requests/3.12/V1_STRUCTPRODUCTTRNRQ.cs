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
    /// 3.12.6.1定活互转结构性存款产品信息查询请求主体
    /// </summary>
    public class V1_STRUCTPRODUCTTRNRQ : IRequest<V1_STRUCTPRODUCTTRNRS>
    {
        /// <summary>
        /// 3.12.6.1定活互转结构性存款产品信息查询请求主体
        /// </summary>
        public STRUCTPRODUCTTRNRQ STRUCTPRODUCTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.6.1定活互转结构性存款产品信息查询请求主体
    /// </summary>
    public class STRUCTPRODUCTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.6.1定活互转结构性存款产品信息查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public STRUCTPRODUCTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.6.1定活互转结构性存款产品信息查询请求内容
    /// </summary>
    public class STRUCTPRODUCTTRN_RQBODY
    {
        /// <summary>
        /// 上网登记的人民币活期账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string DEMANDACCT { get; set; }
    }
}
