using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 业务请求基类
    /// </summary>
    public abstract class BIZRQBASE
    {
        /// <summary>
        /// 客户端交易的唯一流水号，最长30位，必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string TRNUID { get; set; }
    }
}
