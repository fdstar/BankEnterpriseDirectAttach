using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.6电子商业汇票背书转让申请响应主体
    /// </summary>
    public class V1_EBENDRSTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.6电子商业汇票背书转让申请响应主体
        /// </summary>
        public EBENDRSTRNRS EBENDRSTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.6电子商业汇票背书转让申请响应主体
    /// </summary>
    public class EBENDRSTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.6电子商业汇票背书转让申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBENDRSTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.6电子商业汇票背书转让申请响应内容
    /// </summary>
    public class EBENDRSTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
