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
    /// 3.20.10出口信用证来证通知查询请求主体
    /// </summary>
    public class V1_LCCOMENOTICEQUERYTRNRQ : IRequest<V1_LCCOMENOTICEQUERYTRNRS>
    {
        /// <summary>
        /// 3.20.10出口信用证来证通知查询请求主体
        /// </summary>
        public LCCOMENOTICEQUERYTRNRQ LCCOMENOTICEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.20.10出口信用证来证通知查询请求主体
    /// </summary>
    public class LCCOMENOTICEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.20.10出口信用证来证通知查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCOPENNOTICEQUERYTRN_RQBODY RQBODY { get; set; }
    }
}
