using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 中信银行请求基类
    /// </summary>
    /// <typeparam name="R">业务响应类型</typeparam>
    public abstract class RqBase<R> : IRequest<R>
        where R : IResponse
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public abstract string Action { get; set; }
        /// <summary>
        /// 登录名 char(30)
        /// </summary>
        [XmlElement("userName")]
        public string UserName { get; set; }
        /// <summary>
        /// 当前的请求报文，只有在执行请求后才会由程序赋值
        /// </summary>
        [XmlIgnore]
        public string RequestContent { get; internal set; }
    }
}
