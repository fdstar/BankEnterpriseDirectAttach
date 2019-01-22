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
    /// 3.5.3第三方存管签约查询请求主体
    /// </summary>
    public class V1_TPCONTRTRNRQ : IRequest<V1_TPCONTRTRNRS>
    {
        /// <summary>
        /// 3.5.3第三方存管签约查询请求主体
        /// </summary>
        public TPCONTRTRNRQ TPCONTRTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.3第三方存管签约查询请求主体
    /// </summary>
    public class TPCONTRTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.3第三方存管签约查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public TPCONTRTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.3第三方存管签约查询请求内容
    /// </summary>
    public class TPCONTRTRN_RQBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 查询类型  BANK_TRUSTEE (普通存管)  BANK_STOCKTXN (融资融券) 默认BANK_TRUSTEE 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string TRUSTEETYPE { get; set; } = "BANK_TRUSTEE";
    }
}
