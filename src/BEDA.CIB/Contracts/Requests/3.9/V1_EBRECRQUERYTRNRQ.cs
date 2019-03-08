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
    /// 3.9.1.8电子商业汇票可追索人查询请求主体
    /// </summary>
    public class V1_EBRECRQUERYTRNRQ : IRequest<V1_EBRECRQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.8电子商业汇票可追索人查询请求主体
        /// </summary>
        public EBRECRQUERYTRNRQ EBRECRQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.8电子商业汇票可追索人查询请求主体
    /// </summary>
    public class EBRECRQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.8电子商业汇票可追索人查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBRECRQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.8电子商业汇票可追索人查询请求内容
    /// </summary>
    public class EBRECRQUERYTRN_RQBODY : EBFACEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
    }
}
