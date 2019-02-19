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
    /// 3.9.1.7电子商业汇票支付信用信息查询请求主体
    /// </summary>
    public class V1_EBCRDQUERYTRNRQ : IRequest<V1_EBCRDQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.7电子商业汇票支付信用信息查询请求主体
        /// </summary>
        public EBCRDQUERYTRNRQ EBCRDQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.7电子商业汇票支付信用信息查询请求主体
    /// </summary>
    public class EBCRDQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.7电子商业汇票支付信用信息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBCRDQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.7电子商业汇票支付信用信息查询请求内容
    /// </summary>
    public class EBCRDQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 操作员账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 开户行号,最大12位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BANKNUM { get; set; }
    }
}
