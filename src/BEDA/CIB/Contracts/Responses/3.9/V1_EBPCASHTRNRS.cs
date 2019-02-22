using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.3.6电子商业汇票贴现申请响应主体
    /// </summary>
    public class V1_EBPCASHTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.6电子商业汇票贴现申请响应主体
        /// </summary>
        public EBPCASHTRNRS EBPCASHTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.6电子商业汇票贴现申请响应主体
    /// </summary>
    public class EBPCASHTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.6电子商业汇票贴现申请响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPCASHTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.6电子商业汇票贴现申请响应内容
    /// </summary>
    public class EBPCASHTRN_RSBODY
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
        /// 3.9.3.6电子商业汇票贴现申请响应集合	必回
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<Requests.EBPCASHTRN_CONTENT> List { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
