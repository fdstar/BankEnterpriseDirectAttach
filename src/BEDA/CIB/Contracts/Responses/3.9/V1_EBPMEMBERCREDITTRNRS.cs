using BEDA.CIB.Contracts.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.22电子商业汇票成员单位用信申请响应主体
    /// </summary>
    public class V1_EBPMEMBERCREDITTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.22电子商业汇票成员单位用信申请响应主体
        /// </summary>
        public EBPMEMBERCREDITTRNRS EBPMEMBERCREDITTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.22电子商业汇票成员单位用信申请响应主体
    /// </summary>
    public class EBPMEMBERCREDITTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.22电子商业汇票成员单位用信申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPMEMBERCREDITTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.22电子商业汇票成员单位用信申请响应内容
    /// </summary>
    public class EBPMEMBERCREDITTRN_RSBODY : EBPMEMBERCREDITTRN_RQBODY
    {
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 40)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
