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
    /// 3.9.1.3电子商业汇票待签收票据查询请求主体
    /// </summary>
    public class V1_EBSIGNQUERYTRNRQ : IRequest<V1_EBSIGNQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.3电子商业汇票待签收票据查询请求主体
        /// </summary>
        public EBSIGNQUERYTRNRQ EBSIGNQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.3电子商业汇票待签收票据查询请求主体
    /// </summary>
    public class EBSIGNQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.3电子商业汇票待签收票据查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBSIGNQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.3电子商业汇票待签收票据查询请求内容
    /// </summary>
    public class EBSIGNQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 业务编码 ，见附录3:通用签收业务类型对照表	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 票据号码,30位	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 操作员账户代号（将进行签收的操作账号） 最大32位 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 对方行业务申请日期范围	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public DATERANGE APPDTSTART { get; set; }
        /// <summary>
        /// 票据金额范围	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public AMTRANGE BILLAMT { get; set; }
        /// <summary>
        /// 票据类型(AC01:银票,AC02:商票)	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string BILLTYPE { get; set; }
    }
}
