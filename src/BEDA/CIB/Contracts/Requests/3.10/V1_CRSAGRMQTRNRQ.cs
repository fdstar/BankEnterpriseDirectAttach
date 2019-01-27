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
    /// 3.10.2跨行账户他行账户协议查询请求主体
    /// </summary>
    public class V1_CRSAGRMQTRNRQ : IRequest<V1_CRSAGRMQTRNRS>
    {
        /// <summary>
        /// 3.10.2跨行账户他行账户协议查询请求主体
        /// </summary>
        public CRSAGRMQTRNRQ CRSAGRMQTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.10.2跨行账户他行账户协议查询请求主体
    /// </summary>
    public class CRSAGRMQTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.10.2跨行账户他行账户协议查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CRSAGRMQTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.10.2跨行账户他行账户协议查询请求内容
    /// </summary>
    public class CRSAGRMQTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 查询账户代号（兴业账户代号），最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 协议类型，1-付款 2-查询 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int AGRMTYPE { get; set; }
    }
}
