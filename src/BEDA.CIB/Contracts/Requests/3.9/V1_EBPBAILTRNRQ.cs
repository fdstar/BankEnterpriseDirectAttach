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
    /// 3.9.3.7电子商业汇票保证金提取请求主体
    /// </summary>
    public class V1_EBPBAILTRNRQ : IRequest<V1_EBPBAILTRNRS>
    {
        /// <summary>
        /// 3.9.3.7电子商业汇票保证金提取请求主体
        /// </summary>
        public EBPBAILTRNRQ EBPBAILTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.7电子商业汇票保证金提取请求主体
    /// </summary>
    public class EBPBAILTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.7电子商业汇票保证金提取请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPBAILTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.7电子商业汇票保证金提取请求内容
    /// </summary>
    public class EBPBAILTRN_RQBODY
    {
        /// <summary>
        /// 提取金额（18,2）	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal DRAWAMT { get; set; }
        /// <summary>
        /// 保证金账户，查询商票签约信息来获取	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 转入账号	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string TOACCTNO { get; set; }
    }
}
