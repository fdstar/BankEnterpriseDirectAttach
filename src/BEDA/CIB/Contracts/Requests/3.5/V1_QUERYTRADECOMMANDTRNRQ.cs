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
    /// 3.5.13证券交易类指令查询请求主体
    /// </summary>
    public class V1_QUERYTRADECOMMANDTRNRQ : IRequest<V1_QUERYTRADECOMMANDTRNRS>
    {
        /// <summary>
        /// 3.5.13证券交易类指令查询请求主体
        /// </summary>
        public QUERYTRADECOMMANDTRNRQ QUERYTRADECOMMANDTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.13证券交易类指令查询请求主体
    /// </summary>
    public class QUERYTRADECOMMANDTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.13证券交易类指令查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public QUERYTRADECOMMANDTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.13证券交易类指令查询请求内容
    /// </summary>
    public class QUERYTRADECOMMANDTRN_RQBODY : PAGED_RQACCT
    {
        /// <summary>
        /// 客户交易流水号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLIENTREF { get; set; }
        /// <summary>
        /// 业务类型  必输
        /// 0-第三方存管
        /// 1-融资融券
        /// 2-银衍转账
        /// 3-银期直通车转账
        /// 4-期权现货转账
        /// </summary>
        [XmlElement(Order = 2)]
        public int BUSINESSTYPE { get; set; }
    }
}
