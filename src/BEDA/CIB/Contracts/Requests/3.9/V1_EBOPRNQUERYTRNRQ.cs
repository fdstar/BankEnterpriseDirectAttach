using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.1.2电子商业汇票可操作票据查询请求主体
    /// </summary>
    public class V1_EBOPRNQUERYTRNRQ : IRequest<V1_EBOPRNQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.2电子商业汇票可操作票据查询请求主体
        /// </summary>
        public EBOPRNQUERYTRNRQ EBOPRNQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.2电子商业汇票可操作票据查询请求主体
    /// </summary>
    public class EBOPRNQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.2电子商业汇票可操作票据查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBOPRNQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.2电子商业汇票可操作票据查询请求内容
    /// </summary>
    public class EBOPRNQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 业务编码 参见附录《电子票据系统编码对照表》	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 票据号码	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 查询账户代号	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 出票日日期范围	非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public DATERANGE DRAWDATE { get; set; }
        /// <summary>
        /// 票据到期日日期范围	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public DATERANGE DUEDATE { get; set; }
        /// <summary>
        /// 赎回开始日日期范围	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public DATERANGE REDMDTSTART { get; set; }
        /// <summary>
        /// 赎回到期日日期范围	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public DATERANGE REDMDTEND { get; set; }
        /// <summary>
        /// 票据金额范围	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public AMTRANGE BILLAMT { get; set; }
        /// <summary>
        /// 票据种类 (AC01:银票,AC02:商票)	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string BILLTYPE { get; set; }
    }
}
