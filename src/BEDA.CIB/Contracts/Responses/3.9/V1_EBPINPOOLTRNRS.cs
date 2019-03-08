using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.1电子商业汇票票据入池响应主体
    /// </summary>
    public class V1_EBPINPOOLTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.1电子商业汇票票据入池响应主体
        /// </summary>
        public EBPINPOOLTRNRS EBPINPOOLTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.1电子商业汇票票据入池响应主体
    /// </summary>
    public class EBPINPOOLTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.1电子商业汇票票据入池响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPINPOOLTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.1电子商业汇票票据入池响应内容
    /// </summary>
    public class EBPINPOOLTRN_RSBODY
    {
        /// <summary>
        /// 入池方式 ：01-托管入池 02-质押入池	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string INPOOLTYPE { get; set; }
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
        /// 3.9.3.1电子商业汇票票据入池请求集合	必回
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<Requests.EBPINPOOLTRN_CONTENT> List { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
