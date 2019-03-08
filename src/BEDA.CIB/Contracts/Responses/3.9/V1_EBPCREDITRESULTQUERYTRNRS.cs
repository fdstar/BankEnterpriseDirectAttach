using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.24电子商业汇票用信处理结果查询响应主体
    /// </summary>
    public class V1_EBPCREDITRESULTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.24电子商业汇票用信处理结果查询响应主体
        /// </summary>
        public EBPCREDITRESULTQUERYTRNRS EBPCREDITRESULTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.24电子商业汇票用信处理结果查询响应主体
    /// </summary>
    public class EBPCREDITRESULTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.24电子商业汇票用信处理结果查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCREDITRESULTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.24电子商业汇票用信处理结果查询响应内容
    /// </summary>
    public class EBPCREDITRESULTQUERYTRN_RSBODY
    {
        /// <summary>
        /// 处理状态  必回
        /// 0-未审批  
        /// 1-审批中  
        /// 2-审批通过  
        /// 3-审批不通过  
        /// 4-处理失败
        /// </summary>
        [XmlElement(Order = 2)]
        public int STATUS { get; set; }
    }
}
