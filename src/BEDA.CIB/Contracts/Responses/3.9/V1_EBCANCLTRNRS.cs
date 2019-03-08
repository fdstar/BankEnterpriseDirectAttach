using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.5电子商业汇票撤票申请响应主体
    /// </summary>
    public class V1_EBCANCLTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.5电子商业汇票撤票申请响应主体
        /// </summary>
        public EBCANCLTRNRS EBCANCLTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.5电子商业汇票撤票申请响应主体
    /// </summary>
    public class EBCANCLTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.5电子商业汇票撤票申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBCANCLTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.5电子商业汇票撤票申请响应内容
    /// </summary>
    public class EBCANCLTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
