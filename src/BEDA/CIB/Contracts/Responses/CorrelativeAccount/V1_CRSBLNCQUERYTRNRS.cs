using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.10.3跨行账户他行账户余额查询响应主体
    /// </summary>
    public class V1_CRSBLNCQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.10.3跨行账户他行账户余额查询响应主体
        /// </summary>
        public CRSBLNCQUERYTRNRS CRSBLNCQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.10.3跨行账户他行账户余额查询响应主体
    /// </summary>
    public class CRSBLNCQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.10.3跨行账户他行账户余额查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CRSBLNCQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.10.3跨行账户他行账户余额查询响应内容
    /// </summary>
    public class CRSBLNCQUERYTRN_RSBODY
    {
        /// <summary>
        /// 我行账户，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string OPERACCTID { get; set; }
        /// <summary>
        /// 他行账户
        /// </summary>
        [XmlElement(Order = 1)]
        public CORRELATEACCT INTERACCT { get; set; }
        /// <summary>
        /// 余额，decimal(15,2) 即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BALAMT { get; set; }
    }
}
