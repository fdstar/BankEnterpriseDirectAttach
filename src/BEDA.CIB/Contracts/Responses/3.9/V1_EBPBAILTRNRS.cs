using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.7电子商业汇票保证金提取响应主体
    /// </summary>
    public class V1_EBPBAILTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.7电子商业汇票保证金提取响应主体
        /// </summary>
        public EBPBAILTRNRS EBPBAILTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.7电子商业汇票保证金提取响应主体
    /// </summary>
    public class EBPBAILTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.7电子商业汇票保证金提取响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPBAILTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.7电子商业汇票保证金提取响应内容
    /// </summary>
    public class EBPBAILTRN_RSBODY : Requests.EBPBAILTRN_RQBODY
    {
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
