using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 业务处理响应结果基类
    /// </summary>
    public abstract class BIZRSBASE
    {
        /// <summary>
        /// 客户端交易的唯一标志，必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string TRNUID { get; set; }
        /// <summary>
        /// 交易处理状态，必回
        /// </summary>
        [XmlElement(Order = 1)]
        public STATUS STATUS { get; set; }
    }
}
