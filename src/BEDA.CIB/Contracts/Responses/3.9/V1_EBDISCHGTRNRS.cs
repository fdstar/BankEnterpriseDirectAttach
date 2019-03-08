using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.13电子商业汇票同意清偿通知申请响应主体
    /// </summary>
    public class V1_EBDISCHGTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.13电子商业汇票同意清偿通知申请响应主体
        /// </summary>
        public EBDISCHGTRNRS EBDISCHGTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.13电子商业汇票同意清偿通知申请响应主体
    /// </summary>
    public class EBDISCHGTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.13电子商业汇票同意清偿通知申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBDISCHGTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.13电子商业汇票同意清偿通知申请响应内容
    /// </summary>
    public class EBDISCHGTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
