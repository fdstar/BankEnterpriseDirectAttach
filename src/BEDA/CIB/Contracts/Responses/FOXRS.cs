using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 响应实体
    /// </summary>
    [XmlRoot("FOX")]
    public class FOXRS 
    {
        /// <summary>
        /// 服务端响应报文
        /// </summary>
        [XmlIgnore]
        public string ResponseContent { get; set; }
        /// <summary>
        /// 登录消息响应实体
        /// </summary>
        [XmlElement(Order = 0)]
        public SIGNONMSGSRSV1 SIGNONMSGSRSV1 { get; set; }
    }
    /// <summary>
    /// 业务响应实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [XmlRoot("FOX")]
    public class FOXRS<T> : FOXRS
        where T : IResponse
    {
        /// <summary>
        /// 响应主体
        /// </summary>
        [XmlElement(Order = 1)]
        public T SECURITIES_MSGSRSV1 { get; set; }
    }
}
