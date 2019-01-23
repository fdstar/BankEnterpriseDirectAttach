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
    /// 3.8.6理产产品客户信息查询请求主体
    /// </summary>
    public class V1_FPCUSTTRNRQ : IRequest<V1_FPCUSTTRNRS>
    {
        /// <summary>
        /// 3.8.6理产产品客户信息查询请求主体
        /// </summary>
        public FPCUSTTRNRQ FPCUSTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.6理产产品客户信息查询请求主体
    /// </summary>
    public class FPCUSTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.6理产产品客户信息查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public RQACCT RQBODY { get; set; }
    }
}
