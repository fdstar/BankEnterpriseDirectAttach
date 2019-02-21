using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.11电子商业汇票提示付款申请响应主体
    /// </summary>
    public class V1_EBCUEPAYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.11电子商业汇票提示付款申请响应主体
        /// </summary>
        public EBCUEPAYTRNRS EBCUEPAYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.11电子商业汇票提示付款申请响应主体
    /// </summary>
    public class EBCUEPAYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.11电子商业汇票提示付款申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBCUEPAYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.11电子商业汇票提示付款申请响应内容
    /// </summary>
    public class EBCUEPAYTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
