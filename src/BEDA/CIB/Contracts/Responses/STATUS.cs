using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 交易处理状态节点
    /// </summary>
    public class STATUS
    {
        /// <summary>
        /// 处理结果码，0表示正常，其余均为异常
        /// </summary>
        [XmlElement(Order = 0)]
        public int CODE { get; set; }
        /// <summary>
        /// 处理结果等级(INFO/WARN/ERROR)
        /// </summary>
        [XmlElement(Order = 1)]
        public SEVERITYEnum SEVERITY { get; set; }
        /// <summary>
        /// 信息描述
        /// </summary>
        [XmlElement(Order = 2)]
        public string MESSAGE { get; set; }
        /// <summary>
        /// 响应结果是否正确
        /// </summary>
        [XmlIgnore]
        public bool IsCorrect => this.CODE == 0;
    }
}
