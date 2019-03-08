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
    /// 3.11.1.6出入金明细查询请求主体
    /// </summary>
    public class V1_PMSTMTQUERYTRNRQ : IRequest<V1_PMSTMTQUERYTRNRS>
    {
        /// <summary>
        /// 3.11.1.6出入金明细查询请求主体
        /// </summary>
        public PMSTMTQUERYTRNRQ PMSTMTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.11.1.6出入金明细查询请求主体
    /// </summary>
    public class PMSTMTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.11.1.6出入金明细查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMSTMTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.6出入金明细查询请求内容
    /// </summary>
    public class PMSTMTQUERYTRN_RQBODY : PAGED_RQACCT
    {
        /// <summary>
        /// 起始日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起始日期 YYYY-MM-DD, 对应<see cref="DTSTART"/> 必输
        /// </summary>
        [XmlElement("DTSTART", Order = 3)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 终止日期 YYYY-MM-DD, 对应<see cref="DTEND"/> 必输
        /// </summary>
        [XmlElement("DTEND", Order = 4)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
    }
}
