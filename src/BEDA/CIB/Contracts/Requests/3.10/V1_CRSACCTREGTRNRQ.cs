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
    /// 3.10.1跨行账户他行账户登记请求主体
    /// </summary>
    public class V1_CRSACCTREGTRNRQ : IRequest<V1_CRSACCTREGTRNRS>
    {
        /// <summary>
        /// 3.10.1跨行账户他行账户登记请求主体
        /// </summary>
        public CRSACCTREGTRNRQ CRSACCTREGTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.10.1跨行账户他行账户登记请求主体
    /// </summary>
    public class CRSACCTREGTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.10.1跨行账户他行账户登记请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CRSACCTREGTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.10.1跨行账户他行账户登记请求内容
    /// </summary>
    public class CRSACCTREGTRN_RQBODY
    {
        /// <summary>
        /// 协议号，最长140 协议号可通过他行账户协议查询获取 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string AGRM { get; set; }
        /// <summary>
        /// 协议类型，1付款2查询	必输  
        /// </summary>
        [XmlElement(Order = 1)]
        public int AGRMTYPE { get; set; }
        /// <summary>
        /// 他行账户，最长32位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string INTERACCTID { get; set; }
        /// <summary>
        /// 操作类型   必输
        /// ADD增加他行账户
        /// DEL删除他行帐户
        /// </summary>
        [XmlElement(Order = 3)]
        public string OPERTYPE { get; set; }
        /// <summary>
        /// 发起账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string OPERACCTID { get; set; }
    }
}
