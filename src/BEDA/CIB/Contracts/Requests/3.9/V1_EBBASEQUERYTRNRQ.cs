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
    /// 3.9.1.5电子商业汇票票据基本信息查询请求主体
    /// </summary>
    public class V1_EBBASEQUERYTRNRQ : IRequest<V1_EBBASEQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.5电子商业汇票票据基本信息查询请求主体
        /// </summary>
        public EBBASEQUERYTRNRQ EBBASEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.5电子商业汇票票据基本信息查询请求主体
    /// </summary>
    public class EBBASEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.5电子商业汇票票据基本信息查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBBASEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.5电子商业汇票票据基本信息查询请求内容
    /// </summary>
    public class EBBASEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 票据号码,30位	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 操作员账户代号 最大32位 必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 业务标识码, 2位见:附录-票据基本信息查询业务类型对照表	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BIZ { get; set; }
        /// <summary>
        /// 票据类型(AC01:银票,AC02:商票)	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 查询人类型，01发起方 02接收方 03持票人 必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string QUERYERTYPE { get; set; }
        /// <summary>
        /// 出票日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public DATERANGE DRAWDATE { get; set; }
        /// <summary>
        /// 票据到期日 YYYY-MM-DD	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public DATERANGE DUEDATE { get; set; }
        /// <summary>
        /// 票据金额范围	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public AMTRANGE BILLAMT { get; set; }
    }
}
