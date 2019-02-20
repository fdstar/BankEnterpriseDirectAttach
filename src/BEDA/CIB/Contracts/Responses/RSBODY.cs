using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 仅有XFERPRCSTS处理节点的响应内容
    /// </summary>
    public class XFERPRCSTS_RSBODY
    {
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 分页查询时的响应内容
    /// </summary>
    public class PAGED_RSBODY<T>
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 响应集合内容
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<T> List { get; set; }
    }
}
