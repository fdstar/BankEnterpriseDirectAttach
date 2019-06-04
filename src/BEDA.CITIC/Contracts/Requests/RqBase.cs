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
    /// <typeparam name="T"></typeparam>
    public abstract class RqBase<T> : CITICBase<T>
    {
        /// <summary>
        /// 对应请求代码
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }
        /// <summary>
        /// 登录名 char(30)
        /// </summary>
        [XmlElement("userName")]
        public string UserName { get; set; }
    }
}
