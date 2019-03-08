using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.12电子商业汇票追索通知申请响应主体
    /// </summary>
    public class V1_EBRECRSTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.12电子商业汇票追索通知申请响应主体
        /// </summary>
        public EBRECRSTRNRS EBRECRSTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.12电子商业汇票追索通知申请响应主体
    /// </summary>
    public class EBRECRSTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.12电子商业汇票追索通知申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBRECRSTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.12电子商业汇票追索通知申请响应内容
    /// </summary>
    public class EBRECRSTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
