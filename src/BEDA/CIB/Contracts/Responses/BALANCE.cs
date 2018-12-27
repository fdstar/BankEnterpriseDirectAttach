using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 余额
    /// </summary>
    public class BALANCE
    {
        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement(Order = 0)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 日期 yyyy-MM-dd
        /// </summary>
        [XmlElement(Order = 1)]
        public string DTASOF { get; set; }
    }
}
