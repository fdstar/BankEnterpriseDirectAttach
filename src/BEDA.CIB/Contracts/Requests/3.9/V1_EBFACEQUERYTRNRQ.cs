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
    /// 3.9.1.4电子商业汇票票据正面信息查询请求主体
    /// </summary>
    public class V1_EBFACEQUERYTRNRQ : IRequest<V1_EBFACEQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.4电子商业汇票票据正面信息查询请求主体
        /// </summary>
        public EBFACEQUERYTRNRQ EBFACEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.4电子商业汇票票据正面信息查询请求主体
    /// </summary>
    public class EBFACEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.4电子商业汇票票据正面信息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBFACEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.4电子商业汇票票据正面信息查询请求内容
    /// </summary>
    public class EBFACEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 操作员账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
    }
}
