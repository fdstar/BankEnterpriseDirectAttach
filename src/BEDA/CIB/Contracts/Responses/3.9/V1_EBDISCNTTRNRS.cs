using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请响应主体
    /// </summary>
    public class V1_EBDISCNTTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请响应主体
        /// </summary>
        public EBDISCNTTRNRS EBDISCNTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请响应主体
    /// </summary>
    public class EBDISCNTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBDISCNTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.7电子商业汇票贴现申请/转贴现申请/再贴现申请响应内容
    /// </summary>
    public class EBDISCNTTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
