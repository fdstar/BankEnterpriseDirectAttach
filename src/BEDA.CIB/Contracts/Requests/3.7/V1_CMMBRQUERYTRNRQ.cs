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
    /// 集团成员账户查询请求主体
    /// </summary>
    public class V1_CMMBRQUERYTRNRQ : IRequest<V1_CMMBRQUERYTRNRS>
    {
        /// <summary>
        /// 集团成员账户查询
        /// </summary>
        public CMMBRQUERYTRNRQ CMMBRQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 集团成员账户查询
    /// </summary>
    public class CMMBRQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 集团成员账户查询请求主体
        /// </summary>
        [XmlElement(Order = 1)]
        public CMMBRQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 集团成员账户查询请求主体
    /// </summary>
    public class CMMBRQUERYTRN_RQBODY
    {
        /// <summary>
        /// 请求响应的页数（代表从第几页开始查询，默认1）（必输）
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 结算中心账户信息  必输
        /// </summary>
        public RQACCT FUNDACCT { get; set; }
    }
}
