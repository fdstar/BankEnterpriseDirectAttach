using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.15电子商业汇票通用签收/拒签请求响应主体
    /// </summary>
    public class V1_EBSIGNTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.15电子商业汇票通用签收/拒签请求响应主体
        /// </summary>
        public EBSIGNTRNRS EBSIGNTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.15电子商业汇票通用签收/拒签请求响应主体
    /// </summary>
    public class EBSIGNTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.15电子商业汇票通用签收/拒签请求响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBSIGNTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.15电子商业汇票通用签收/拒签请求响应内容
    /// </summary>
    public class EBSIGNTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
