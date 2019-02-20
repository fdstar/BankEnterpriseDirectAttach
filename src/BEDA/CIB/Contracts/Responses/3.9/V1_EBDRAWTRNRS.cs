using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.1电子商业汇票出票申请/出票信息登记响应主体
    /// </summary>
    public class V1_EBDRAWTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.1电子商业汇票出票申请/出票信息登记响应主体
        /// </summary>
        public EBDRAWTRNRS EBDRAWTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.1电子商业汇票出票申请/出票信息登记响应主体
    /// </summary>
    public class EBDRAWTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.1电子商业汇票出票申请/出票信息登记响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBDRAWTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.1电子商业汇票出票申请/出票信息登记响应内容
    /// </summary>
    public class EBDRAWTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
