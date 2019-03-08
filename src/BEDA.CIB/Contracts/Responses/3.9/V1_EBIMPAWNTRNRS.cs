using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.9电子商业汇票质押申请响应主体
    /// </summary>
    public class V1_EBIMPAWNTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.9电子商业汇票质押申请响应主体
        /// </summary>
        public EBIMPAWNTRNRS EBIMPAWNTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.9电子商业汇票质押申请响应主体
    /// </summary>
    public class EBIMPAWNTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.9电子商业汇票质押申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBIMPAWNTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.9电子商业汇票质押申请响应内容
    /// </summary>
    public class EBIMPAWNTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
