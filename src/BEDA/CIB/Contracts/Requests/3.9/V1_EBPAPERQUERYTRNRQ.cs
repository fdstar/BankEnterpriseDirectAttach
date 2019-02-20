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
    /// 3.9.1.12电子商业汇票代保管纸质票据查询请求主体
    /// </summary>
    public class V1_EBPAPERQUERYTRNRQ : IRequest<V1_EBPAPERQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.12电子商业汇票代保管纸质票据查询请求主体
        /// </summary>
        public EBPAPERQUERYTRNRQ EBPAPERQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.12电子商业汇票代保管纸质票据查询请求主体
    /// </summary>
    public class EBPAPERQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.12电子商业汇票代保管纸质票据查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPAPERQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.12电子商业汇票代保管纸质票据查询请求内容
    /// </summary>
    public class EBPAPERQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 查询账户代号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 批量标识号	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string BATCHNO { get; set; }
        /// <summary>
        /// 业务类型：0 代保管 1解除代保管	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int BIZ { get; set; }
        /// <summary>
        /// 票据种类，AC01银承 AC02商承	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 查询日期范围	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public DATERANGE KEPTDATE { get; set; }
        /// <summary>
        /// 纸质票据号码	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 出票日期范围	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public DATERANGE DRAWDATE { get; set; }
        /// <summary>
        /// 票据到期日范围	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public DATERANGE DUEDATE { get; set; }
        /// <summary>
        /// 承兑人	非必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string ACPTOR { get; set; }
        /// <summary>
        /// 票据金额范围	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public AMTRANGE BILLAMT { get; set; }
    }
}
