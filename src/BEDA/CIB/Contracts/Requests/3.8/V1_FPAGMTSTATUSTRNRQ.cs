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
    /// 3.8.8理财产品签约状态查询请求主体
    /// </summary>
    public class V1_FPAGMTSTATUSTRNRQ : IRequest<V1_FPAGMTSTATUSTRNRS>
    {
        /// <summary>
        /// 3.8.8理财产品签约状态查询请求主体
        /// </summary>
        public FPAGMTSTATUSTRNRQ FPAGMTSTATUSTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.8理财产品签约状态查询请求主体
    /// </summary>
    public class FPAGMTSTATUSTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.8理财产品签约状态查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FPAGMTSTATUSTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.8.8理财产品签约状态查询请求内容
    /// </summary>
    public class FPAGMTSTATUSTRN_RQBODY : RQACCT
    {
        /// <summary>
        /// 产品代码，8位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string PRODNO { get; set; }
    }
}
