using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.5电子商业汇票融资申请响应主体
    /// </summary>
    public class V1_EBPFINANCINGTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.5电子商业汇票融资申请响应主体
        /// </summary>
        public EBPFINANCINGTRNRS EBPFINANCINGTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.5电子商业汇票融资申请响应主体
    /// </summary>
    public class EBPFINANCINGTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.5电子商业汇票融资申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPFINANCINGTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.5电子商业汇票融资申请响应内容
    /// </summary>
    public class EBPFINANCINGTRN_RSBODY : Requests.EBPFINANCINGTRN_RQBODY
    {
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
