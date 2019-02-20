using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.3电子商业汇票提示承兑申请响应主体
    /// </summary>
    public class V1_EBACPTTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.3电子商业汇票提示承兑申请响应主体
        /// </summary>
        public EBACPTTRNRS EBACPTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.3电子商业汇票提示承兑申请响应主体
    /// </summary>
    public class EBACPTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.3电子商业汇票提示承兑申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBACPTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.3电子商业汇票提示承兑申请响应内容
    /// </summary>
    public class EBACPTTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
