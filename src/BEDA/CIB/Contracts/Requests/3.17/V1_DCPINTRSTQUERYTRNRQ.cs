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
    /// 3.17.3虚拟资金池利息查询请求主体
    /// </summary>
    public class V1_DCPINTRSTQUERYTRNRQ : IRequest<V1_DCPINTRSTQUERYTRNRS>
    {
        /// <summary>
        /// 3.17.3虚拟资金池利息查询请求主体
        /// </summary>
        public DCPINTRSTQUERYTRNRQ DCPINTRSTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.3虚拟资金池利息查询请求主体
    /// </summary>
    public class DCPINTRSTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.3虚拟资金池利息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public DCPINTRSTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.3虚拟资金池利息查询请求内容
    /// </summary>
    public class DCPINTRSTQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页码
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 主账户账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 成员活期账户代号，18位 如果有输入，则查询成员账号的担保利息。如果没有输入，则查询主账户下所有成员账号的担保利息 非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string MEMACCT { get; set; }
    }
}
