using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.4工资发放服务请求对应的响应主体
    /// </summary>
    public class V1_RPAYOFFINQTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.4工资发放服务请求对应的响应
        /// </summary>
        public RPAYOFFINQTRNRS RPAYOFFINQTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.4工资发放服务请求对应的响应
    /// </summary>
    public class RPAYOFFINQTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 工资指令响应
        /// </summary>
        [XmlElement(Order = 3)]
        public RPAYOFFRS RPAYOFFRS { get; set; }
    }
}
