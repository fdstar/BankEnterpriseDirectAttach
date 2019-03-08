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
    /// 3.17.4资金池签约关系及余额查询请求主体
    /// </summary>
    public class V1_QUERYSIGNRELATIONTRNRQ : IRequest<V1_QUERYSIGNRELATIONTRNRS>
    {
        /// <summary>
        /// 3.17.4资金池签约关系及余额查询请求主体
        /// </summary>
        public QUERYSIGNRELATIONTRNRQ QUERYSIGNRELATIONTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.4资金池签约关系及余额查询请求主体
    /// </summary>
    public class QUERYSIGNRELATIONTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.4资金池签约关系及余额查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QUERYSIGNRELATIONTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.4资金池签约关系及余额查询请求内容
    /// </summary>
    public class QUERYSIGNRELATIONTRN_RQBODY
    {
        /// <summary>
        /// 查询页码
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 账号	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户类型 (0-主账户；1-成员账户)  必输
        /// 当输入主账户，则输出所有成员账户及其下的挡板账号信息；
        /// 当输入成员账号，则输出该成员账户及其下的挡板账号信息
        /// </summary>
        [XmlElement(Order = 1)]
        public int ACCTTYPE { get; set; }
    }
}
