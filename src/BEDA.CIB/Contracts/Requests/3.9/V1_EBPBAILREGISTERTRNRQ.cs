using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.19电子商业汇票保证金交易登记薄请求主体
    /// </summary>
    public class V1_EBPBAILREGISTERTRNRQ : IRequest<V1_EBPBAILREGISTERTRNRS>
    {
        /// <summary>
        /// 3.9.3.19电子商业汇票保证金交易登记薄请求主体
        /// </summary>
        public EBPBAILREGISTERTRNRQ EBPBAILREGISTERTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.19电子商业汇票保证金交易登记薄请求主体
    /// </summary>
    public class EBPBAILREGISTERTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.19电子商业汇票保证金交易登记薄请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPBAILREGISTERTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.19电子商业汇票保证金交易登记薄请求内容
    /// </summary>
    public class EBPBAILREGISTERTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 交易起始日期，YYYY-MM-DD，交易时期为历史明细是必输	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGINDATE { get; set; }
        /// <summary>
        /// 交易起始日期，YYYY-MM-DD，交易时期为历史明细是必输，对应<see cref="BEGINDATE"/> 非必输
        /// </summary>
        [XmlElement("BEGINDATE", Order = 1)]
        public string BEGINDATEStr
        {
            get
            {
                return this.BEGINDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.BEGINDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGINDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 交易终止日期, YYYY-MM-DD，交易时期为历史明细是必输	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? DUEDATE { get; set; }
        /// <summary>
        /// 交易终止日期, YYYY-MM-DD，交易时期为历史明细是必输 ,对应<see cref="DUEDATE"/> 非必输
        /// </summary>
        [XmlElement("DUEDATE", Order = 2)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DUEDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 业务类型，01-提取 02-存入 非必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 交易时期 0-当日明细 1-历史明细 必输
        /// </summary>
        [XmlElement(Order = 4)]
        public int TRADEPERIOD { get; set; }
    }
}
