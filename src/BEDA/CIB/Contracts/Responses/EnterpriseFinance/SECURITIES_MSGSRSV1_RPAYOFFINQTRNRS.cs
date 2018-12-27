using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 工资发放服务请求对应的响应主体
    /// </summary>
    public class SECURITIES_MSGSRSV1_RPAYOFFINQTRNRS : IResponse
    {
        /// <summary>
        /// 工资发放服务请求对应的响应
        /// </summary>
        public RPAYOFFINQTRNRS RPAYOFFINQTRNRS { get; set; }
    }
    /// <summary>
    /// 工资发放服务请求对应的响应
    /// </summary>
    public class RPAYOFFINQTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 工资指令响应
        /// </summary>
        [XmlElement(Order = 2)]
        public RPAYOFFRS RPAYOFFRS { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
