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
    /// <typeparam name="T">业务请求类型</typeparam>
    /// <typeparam name="R">业务响应类型</typeparam>
    public abstract class RqBase<T, R> : CITICBase<T>, IRequest<R>
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
    }
}
