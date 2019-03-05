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
    /// 3.20.8进口信用证承兑通知查询请求主体
    /// </summary>
    public class V1_LCACCEPTNOTICEQUERYTRNRQ : IRequest<V1_LCACCEPTNOTICEQUERYTRNRS>
    {
        /// <summary>
        /// 3.20.8进口信用证承兑通知查询请求主体
        /// </summary>
        public LCACCEPTNOTICEQUERYTRNRQ LCACCEPTNOTICEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.20.8进口信用证承兑通知查询请求主体
    /// </summary>
    public class LCACCEPTNOTICEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.20.8进口信用证承兑通知查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCACCEPTNOTICEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.20.8进口信用证承兑通知查询请求内容
    /// </summary>
    public class LCACCEPTNOTICEQUERYTRN_RQBODY : LCREJECTNOTICEQUERYTRN_RQBODY
    {
    }
}
