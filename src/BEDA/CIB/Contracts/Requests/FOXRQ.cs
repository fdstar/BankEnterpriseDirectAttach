using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 请求实体
    /// </summary>
    [XmlRoot("FOX")]
    public class FOXRQ
    {
        /// <summary>
        /// 登录消息请求实体
        /// </summary>
        [XmlElement(Order = 0)]
        public SIGNONMSGSRQV1 SIGNONMSGSRQV1 { get; set; }
    }
    /// <summary>
    /// 业务请求实体
    /// </summary>
    /// <typeparam name="TRequest"><see cref="IRequest{T}"/></typeparam>
    /// <typeparam name="TResponse"><see cref="IResponse"/></typeparam>
    [XmlRoot("FOX")]
    public class FOXRQ<TRequest, TResponse> : FOXRQ
        where TRequest : IRequest<TResponse>
        where TResponse : IResponse
    {
        /// <summary>
        /// 实际业务请求数据
        /// </summary>
        [XmlElement(Order = 1)]
        public TRequest SECURITIES_MSGSRQV1 { get; set; }
    }
}
