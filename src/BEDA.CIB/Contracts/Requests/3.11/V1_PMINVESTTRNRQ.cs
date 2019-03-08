using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.11.2贵金属交易入金申请请求主体
    /// </summary>
    public class V1_PMINVESTTRNRQ : IRequest<V1_PMINVESTTRNRS>
    {
        /// <summary>
        /// 3.11.2贵金属交易入金申请请求主体
        /// </summary>
        public PMINVESTTRNRQ PMINVESTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.2贵金属交易入金申请请求主体
    /// </summary>
    public class PMINVESTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.2贵金属交易入金申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMINVESTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.11.2贵金属交易入金申请请求内容
    /// </summary>
    public class PMINVESTTRN_RQBODY
    {
        /// <summary>
        /// 账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 入金金额，decimal(15,2) 即整数位最长13位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 客户编码，17位	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string CUSTNO { get; set; }
        /// <summary>
        /// 会员编码，17位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string MBRNO { get; set; }
    }
}
