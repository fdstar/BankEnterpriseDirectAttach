using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.10电子商业汇票质押解除申请响应主体
    /// </summary>
    public class V1_EBIMPAWNCANCLTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.10电子商业汇票质押解除申请响应主体
        /// </summary>
        public EBIMPAWNCANCLTRNRS EBIMPAWNCANCLTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.10电子商业汇票质押解除申请响应主体
    /// </summary>
    public class EBIMPAWNCANCLTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.10电子商业汇票质押解除申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBIMPAWNCANCLTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.10电子商业汇票质押解除申请响应内容
    /// </summary>
    public class EBIMPAWNCANCLTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
