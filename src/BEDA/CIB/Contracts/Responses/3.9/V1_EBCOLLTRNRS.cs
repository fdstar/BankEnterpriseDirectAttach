using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.4电子商业汇票提示收票申请响应主体
    /// </summary>
    public class V1_EBCOLLTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.4电子商业汇票提示收票申请响应主体
        /// </summary>
        public EBCOLLTRNRS EBCOLLTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.4电子商业汇票提示收票申请响应主体
    /// </summary>
    public class EBCOLLTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.4电子商业汇票提示收票申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBCOLLTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.4电子商业汇票提示收票申请响应内容
    /// </summary>
    public class EBCOLLTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
