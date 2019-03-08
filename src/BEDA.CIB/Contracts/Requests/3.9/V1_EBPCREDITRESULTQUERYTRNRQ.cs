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
    /// 3.9.3.24电子商业汇票用信处理结果查询请求主体
    /// </summary>
    public class V1_EBPCREDITRESULTQUERYTRNRQ : IRequest<V1_EBPCREDITRESULTQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.24电子商业汇票用信处理结果查询请求主体
        /// </summary>
        public EBPCREDITRESULTQUERYTRNRQ EBPCREDITRESULTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.24电子商业汇票用信处理结果查询请求主体
    /// </summary>
    public class EBPCREDITRESULTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.24电子商业汇票用信处理结果查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCREDITRESULTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.24电子商业汇票用信处理结果查询请求内容
    /// </summary>
    public class EBPCREDITRESULTQUERYTRN_RQBODY
    {
        /// <summary>
        /// 指令相关流水号 	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string RELATETRNUID { get; set; }
    }
}
