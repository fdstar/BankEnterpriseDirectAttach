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
    /// 3.9.1.6电子商业汇票票据流转信息查询请求主体
    /// </summary>
    public class V1_EBBACKQUERYTRNRQ : IRequest<V1_EBBACKQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.6电子商业汇票票据流转信息查询请求主体
        /// </summary>
        public EBBACKQUERYTRNRQ EBBACKQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.6电子商业汇票票据流转信息查询请求主体
    /// </summary>
    public class EBBACKQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.6电子商业汇票票据流转信息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBBACKQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.6电子商业汇票票据流转信息查询请求内容
    /// </summary>
    public class EBBACKQUERYTRN_RQBODY : EBFACEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
    }
}
