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
    /// 3.9.3.9电子商业汇票票据池可操作票据查询请求主体
    /// </summary>
    public class V1_EBPOPERATEBILLQUERYTRNRQ : IRequest<V1_EBPOPERATEBILLQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.9电子商业汇票票据池可操作票据查询请求主体
        /// </summary>
        public EBPOPERATEBILLQUERYTRNRQ EBPOPERATEBILLQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.9电子商业汇票票据池可操作票据查询请求主体
    /// </summary>
    public class EBPOPERATEBILLQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.9电子商业汇票票据池可操作票据查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPOPERATEBILLQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.9电子商业汇票票据池可操作票据查询请求内容
    /// </summary>
    public class EBPOPERATEBILLQUERYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码 不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 查询类型 必输
        /// 01-托管出池
        /// 02-质押出池
        /// 03-托管转质押
        /// 04-质押转托管
        /// 05-贴现
        /// </summary>
        [XmlElement(Order = 2)]
        public string QUERYTYPE { get; set; }
        /// <summary>
        /// 票据类型，AC01银承 AC02商承	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票据号码，16位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 最小票据金额,（18,2）	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINBILLAMT { get; set; }
        /// <summary>
        /// 最小票据金额,（18,2） 对应<see cref="MINBILLAMT"/>	非必输
        /// </summary>
        [XmlElement("MINBILLAMT", Order = 5)]
        public string MINBILLAMTStr
        {
            get
            {
                return this.MINBILLAMT?.ToString();
            }
            set
            {
                this.MINBILLAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 最大票据金额,（18,2）	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXBILLAMT { get; set; }
        /// <summary>
        /// 最大票据金额,（18,2） 对应<see cref="MAXBILLAMT"/>	非必输
        /// </summary>
        [XmlElement("MAXBILLAMT", Order = 6)]
        public string MAXBILLAMTStr
        {
            get
            {
                return this.MAXBILLAMT?.ToString();
            }
            set
            {
                this.MAXBILLAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 起始出票日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGINOUTDATE { get; set; }
        /// <summary>
        /// 起始出票日期 YYYY-MM-DD ,对应<see cref="BEGINOUTDATE"/> 非必输
        /// </summary>
        [XmlElement("BEGINOUTDATE", Order = 7)]
        public string BEGINOUTDATEStr
        {
            get
            {
                return this.BEGINOUTDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BEGINOUTDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 结束出票日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDOUTDATE { get; set; }
        /// <summary>
        /// 结束出票日期 YYYY-MM-DD ,对应<see cref="ENDOUTDATE"/>	非必输
        /// </summary>
        [XmlElement("ENDOUTDATE", Order = 8)]
        public string ENDOUTDATEStr
        {
            get
            {
                return this.ENDOUTDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.ENDOUTDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 起始到期日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGINDUEDATE { get; set; }
        /// <summary>
        /// 起始到期日期 YYYY-MM-DD ,对应<see cref="BEGINDUEDATE"/> 非必输
        /// </summary>
        [XmlElement("BEGINDUEDATE", Order = 9)]
        public string BEGINDUEDATEStr
        {
            get
            {
                return this.BEGINDUEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BEGINDUEDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 结束到期日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDUEDATE { get; set; }
        /// <summary>
        /// 结束到期日期 YYYY-MM-DD ,对应<see cref="ENDDUEDATE"/>	非必输
        /// </summary>
        [XmlElement("ENDDUEDATE", Order = 10)]
        public string ENDDUEDATEStr
        {
            get
            {
                return this.ENDDUEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.ENDDUEDATE = value.TryConvert<DateTime>();
            }
        }
    }
}
