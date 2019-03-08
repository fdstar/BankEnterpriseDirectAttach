using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.2电子商业汇票通用保证申请响应主体
    /// </summary>
    public class V1_EBGUARNTTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.2电子商业汇票通用保证申请响应主体
        /// </summary>
        public EBGUARNTTRNRS EBGUARNTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.2电子商业汇票通用保证申请响应主体
    /// </summary>
    public class EBGUARNTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.2电子商业汇票通用保证申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBGUARNTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.2电子商业汇票通用保证申请响应内容
    /// </summary>
    public class EBGUARNTTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
