using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.8.8理财产品签约状态查询响应主体
    /// </summary>
    public class V1_FPAGMTSTATUSTRNRS : IResponse
    {
        /// <summary>
        /// 3.8.8理财产品签约状态查询响应主体
        /// </summary>
        public FPAGMTSTATUSTRNRS FPAGMTSTATUSTRNRS { get; set; }
    }
    /// <summary>
    /// 3.8.8理财产品签约状态查询响应主体
    /// </summary>
    public class FPAGMTSTATUSTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.8.8理财产品签约状态查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FPAGMTSTATUSTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.8.8理财产品签约状态查询响应内容
    /// </summary>
    public class FPAGMTSTATUSTRN_RSBODY
    {
        /// <summary>
        /// 账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 产品代码，8位
        /// </summary>
        [XmlElement(Order = 1)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 与协议对应的序列号（CIBLCCPxxx）,最长20位
        /// </summary>
        [XmlElement(Order = 2)]
        public string AGRM { get; set; }
        /// <summary>
        /// 签约、解约状态 0-未签约，1-已签约
        /// </summary>
        [XmlElement(Order = 3)]
        public string STATUS { get; set; }
    }
}
