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
    /// 3.9.3.8电子商业汇票票据池处理结果查询请求主体
    /// </summary>
    public class V1_EBPBILLPOOLRESULTQUERYTRNRQ : IRequest<V1_EBPBILLPOOLRESULTQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.8电子商业汇票票据池处理结果查询请求主体
        /// </summary>
        public EBPBILLPOOLRESULTQUERYTRNRQ EBPBILLPOOLRESULTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.8电子商业汇票票据池处理结果查询请求主体
    /// </summary>
    public class EBPBILLPOOLRESULTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.8电子商业汇票票据池处理结果查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPBILLPOOLRESULTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.8电子商业汇票票据池处理结果查询请求内容
    /// </summary>
    public class EBPBILLPOOLRESULTQUERYTRN_RQBODY
    {
        /// <summary>
        /// 指令相关流水号，申请时的TRNUID 	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string RELATETRNUID { get; set; }
    }
}
