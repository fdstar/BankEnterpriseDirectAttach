using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.18.11跨境电商收付汇还原申报响应主体
    /// </summary>
    public class V1_CBECTRANSFERDECLARETRNRS : IResponse
    {
        /// <summary>
        /// 3.18.11跨境电商收付汇还原申报响应主体
        /// </summary>
        public CBECTRANSFERDECLARETRNRS CBECTRANSFERDECLARETRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.11跨境电商收付汇还原申报响应主体
    /// </summary>
    public class CBECTRANSFERDECLARETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.11跨境电商收付汇还原申报响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECTRANSFERDECLARETRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.11跨境电商收付汇还原申报响应内容
    /// </summary>
    public class CBECTRANSFERDECLARETRN_RSBODY : Requests.CBECTRANSFERDECLARETRN_RQBODY
    {
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
