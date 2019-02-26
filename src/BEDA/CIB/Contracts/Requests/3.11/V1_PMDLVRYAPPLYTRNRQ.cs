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
    /// 3.11.4贵金属交易实物提货申请请求主体
    /// </summary>
    public class V1_PMDLVRYAPPLYTRNRQ : IRequest<V1_PMDLVRYAPPLYTRNRS>
    {
        /// <summary>
        /// 3.11.4贵金属交易实物提货申请请求主体
        /// </summary>
        public PMDLVRYAPPLYTRNRQ PMDLVRYAPPLYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.4贵金属交易实物提货申请请求主体
    /// </summary>
    public class PMDLVRYAPPLYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.4贵金属交易实物提货申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMDLVRYAPPLYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.11.4贵金属交易实物提货申请请求内容
    /// </summary>
    public class PMDLVRYAPPLYTRN_RQBODY
    {
        /// <summary>
        /// 账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 品种代码 必输
        /// 201 AU99.99       
        /// 202 AU99.95       
        /// 203 PT99.95       
        /// 207 AU100g
        /// </summary>
        [XmlElement(Order = 3)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 提货重量，decimal(17,2) 即整数位最长15位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal PICKCNT { get; set; }
        /// <summary>
        /// 提货密码，最短6位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string PICKPWD { get; set; }
    }
}
