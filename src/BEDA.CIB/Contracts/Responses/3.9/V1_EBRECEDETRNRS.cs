using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.14电子商业汇票通用撤回请求响应主体
    /// </summary>
    public class V1_EBRECEDETRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.14电子商业汇票通用撤回请求响应主体
        /// </summary>
        public EBRECEDETRNRS EBRECEDETRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.14电子商业汇票通用撤回请求响应主体
    /// </summary>
    public class EBRECEDETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.14电子商业汇票通用撤回请求响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBRECEDETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.14电子商业汇票通用撤回请求响应内容
    /// </summary>
    public class EBRECEDETRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
