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
    /// 3.20.6进口信用证到单通知查询请求主体
    /// </summary>
    public class V1_LCLITDCKNOTICEQUERYTRNRQ : IRequest<V1_LCLITDCKNOTICEQUERYTRNRS>
    {
        /// <summary>
        /// 3.20.6进口信用证到单通知查询请求主体
        /// </summary>
        public LCLITDCKNOTICEQUERYTRNRQ LCLITDCKNOTICEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.20.6进口信用证到单通知查询请求主体
    /// </summary>
    public class LCLITDCKNOTICEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.20.6进口信用证到单通知查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCAMENDNOTICEQUERYTRN_RQBODY RQBODY { get; set; }
    }
}
