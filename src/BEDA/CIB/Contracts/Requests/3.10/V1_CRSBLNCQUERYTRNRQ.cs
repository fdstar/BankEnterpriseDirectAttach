using BEDA.CIB.Contracts.Responses;
using 
    System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.10.3跨行账户他行账户余额查询请求主体
    /// </summary>
    public class V1_CRSBLNCQUERYTRNRQ : IRequest<V1_CRSBLNCQUERYTRNRS>
    {
        /// <summary>
        /// 3.10.3跨行账户他行账户余额查询请求主体
        /// </summary>
        public CRSBLNCQUERYTRNRQ CRSBLNCQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.10.3跨行账户他行账户余额查询请求主体
    /// </summary>
    public class CRSBLNCQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.10.3跨行账户他行账户余额查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CRSBLNCQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.10.3跨行账户他行账户余额查询请求内容
    /// </summary>
    public class CRSBLNCQUERYTRN_RQBODY
    {
        /// <summary>
        /// 3.10.3跨行账户他行账户余额查询(发起请求)
        /// </summary>
        [XmlElement(Order = 0)]
        public CRSBLNCQUERYTRN_QUERYCOND QUERYCOND { get; set; }
        /// <summary>
        /// 第一次查询时用的交易流水号（TRNUID），最长30位 (查询)
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLIENTREF { get; set; }
    }
    /// <summary>
    /// 3.10.3跨行账户他行账户余额查询
    /// </summary>
    public class CRSBLNCQUERYTRN_QUERYCOND
    {
        /// <summary>
        /// 协议号，最长140位	必输 
        /// </summary>
        [XmlElement(Order = 0)]
        public string AGRM { get; set; }
        /// <summary>
        /// 发起账户代号(兴业账户代号)，最长32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string OPERACCTID { get; set; }
    }
}
