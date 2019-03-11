using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 招商银行请求头信息
    /// </summary>
    public class RQINFO : INFO
    {
        /// <summary>
        /// 当前的请求报文，只有在执行请求后才会由程序赋值
        /// </summary>
        [XmlIgnore]
        public string RequestContent { get; internal set; }
        /// <summary>
        /// 登陆用户名	前置机模式必填
        /// </summary>
        public string LGNNAM { get; set; }
    }
}
