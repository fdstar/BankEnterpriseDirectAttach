using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.4电子商业汇票出票申请响应主体
    /// </summary>
    public class V1_EBPOUTBILLTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.4电子商业汇票出票申请响应主体
        /// </summary>
        public EBPOUTBILLTRNRS EBPOUTBILLTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.4电子商业汇票出票申请响应主体
    /// </summary>
    public class EBPOUTBILLTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.4电子商业汇票出票申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPOUTBILLTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.4电子商业汇票出票申请响应内容
    /// </summary>
    public class EBPOUTBILLTRN_RSBODY
    {
        /// <summary>
        /// 票据总笔数	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 票据总金额（18,2） 	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 3.9.3.4电子商业汇票出票申请响应集合	必回
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<Requests.EBPOUTBILLTRN_CONTENT> List { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
