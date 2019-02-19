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
    /// 3.9.1.9电子商业汇票票据批量状态查询请求主体
    /// </summary>
    public class V1_EBBATCHSTATUSTRNRQ : IRequest<V1_EBBATCHSTATUSTRNRS>
    {
        /// <summary>
        /// 3.9.1.9电子商业汇票票据批量状态查询请求主体
        /// </summary>
        public EBBATCHSTATUSTRNRQ EBBATCHSTATUSTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.9电子商业汇票票据批量状态查询请求主体
    /// </summary>
    public class EBBATCHSTATUSTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.9电子商业汇票票据批量状态查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBBATCHSTATUSTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.9电子商业汇票票据批量状态查询请求内容
    /// </summary>
    public class EBBATCHSTATUSTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 操作员账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 客户交易流水号
        /// </summary>
        [XmlElement(Order = 3)]
        public string CLIENTREF { get; set; }
    }
}
