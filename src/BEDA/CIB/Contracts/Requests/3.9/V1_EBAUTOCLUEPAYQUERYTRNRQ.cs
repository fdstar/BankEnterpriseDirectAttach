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
    /// 3.9.1.13电子商业汇票自动提示付款结果查询请求主体
    /// </summary>
    public class V1_EBAUTOCLUEPAYQUERYTRNRQ : IRequest<V1_EBAUTOCLUEPAYQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.1.13电子商业汇票自动提示付款结果查询请求主体
        /// </summary>
        public EBAUTOCLUEPAYQUERYTRNRQ EBAUTOCLUEPAYQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.1.13电子商业汇票自动提示付款结果查询请求主体
    /// </summary>
    public class EBAUTOCLUEPAYQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.1.13电子商业汇票自动提示付款结果查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBAUTOCLUEPAYQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.13电子商业汇票自动提示付款结果查询请求内容
    /// </summary>
    public class EBAUTOCLUEPAYQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 查询账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 交易起始日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGINDATE { get; set; }
        /// <summary>
        /// 交易起始日期 YYYY-MM-DD ,对应<see cref="BEGINDATE"/> 非必输
        /// </summary>
        [XmlElement("BEGINDATE", Order = 3)]
        public string BEGINDATEStr
        {
            get
            {
                return this.BEGINDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BEGINDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 交易结束日期 YYYY-MM-DD	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDATE { get; set; }
        /// <summary>
        /// 交易结束日期 YYYY-MM-DD ,对应<see cref="ENDDATE"/>	非必输
        /// </summary>
        [XmlElement("ENDDATE", Order = 4)]
        public string ENDDATEStr
        {
            get
            {
                return this.ENDDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.ENDDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 查询账号的开户行号
        /// </summary>
        [XmlElement(Order = 5)]
        public string BRNO { get; set; }
        /// <summary>
        /// 票据号码
        /// </summary>
        [XmlElement(Order = 6)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额
        /// </summary>
        [XmlIgnore]
        public decimal? BILLAMT { get; set; }
        /// <summary>
        /// 票据金额 ,对应<see cref="BILLAMT"/>
        /// </summary>
        [XmlElement("BILLAMT", Order = 7)]
        public string BILLAMTStr
        {
            get
            {
                return this.BILLAMT?.ToString();
            }
            set
            {
                this.BILLAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 处理状态
        /// </summary>
        [XmlElement(Order = 8)]
        public string STATUS { get; set; }
    }
}
