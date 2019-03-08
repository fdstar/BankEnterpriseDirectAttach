using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.2电子商业汇票票据出池响应主体
    /// </summary>
    public class V1_EBPOUTPOOLTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.2电子商业汇票票据出池响应主体
        /// </summary>
        public EBPOUTPOOLTRNRS EBPOUTPOOLTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.2电子商业汇票票据出池响应主体
    /// </summary>
    public class EBPOUTPOOLTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.2电子商业汇票票据出池响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPOUTPOOLTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.2电子商业汇票票据出池响应内容
    /// </summary>
    public class EBPOUTPOOLTRN_RSBODY
    {
        /// <summary>
        /// 出池方式 ，01-托管出池 02-质押出池	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string OUTPOOLTYPE { get; set; }
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
        /// 3.9.3.2电子商业汇票票据出池响应集合	必回
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<Requests.EBPOUTPOOLTRN_CONTENT> List { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
