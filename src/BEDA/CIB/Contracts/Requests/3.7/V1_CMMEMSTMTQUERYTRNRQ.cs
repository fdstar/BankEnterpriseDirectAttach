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
    /// 集团服务查询成员外部收支明细请求主体
    /// </summary>
    public class V1_CMMEMSTMTQUERYTRNRQ : IRequest<V1_CMMEMSTMTQUERYTRNRS>
    {
        /// <summary>
        /// 集团服务查询成员外部收支明细请求主体
        /// </summary>
        public CMMEMSTMTQUERYTRNRQ CMMEMSTMTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 集团服务查询成员外部收支明细请求主体
    /// </summary>
    public class CMMEMSTMTQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 集团服务查询成员外部收支明细请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CMMEMSTMTQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 集团服务查询成员外部收支明细请求内容
    /// </summary>
    public class CMMEMSTMTQUERYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 成员单位帐户信息 必输
        /// </summary>
        [XmlElement(Order = 0)]
        public RQACCT MBRACCT { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD ,对应<see cref="DTSTART"/>	必输
        /// </summary>
        [XmlElement("DTSTART", Order = 1)]
        public string DTSTARTStr
        {
            get
            {
                return this.DTSTART.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTSTART = tmp;
                }
            }
        }
        /// <summary>
        /// 截止日期YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 截止日期YYYY-MM-DD ,对应<see cref="DTEND"/>	必输
        /// </summary>
        [XmlElement("DTEND", Order = 2)]
        public string DTENDStr
        {
            get
            {
                return this.DTEND.ToString("yyyy-MM-dd");
            }
            set
            {
                if (value.TryParse(out DateTime tmp))
                {
                    this.DTEND = tmp;
                }
            }
        }
        /// <summary>
        /// 最小金额，decimal(15,2)，即整数最长13位，小数2位	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最小金额，decimal(15,2)，即整数最长13位，小数2位 ,对应<see cref="MINAMT"/>	非必输
        /// </summary>
        [XmlElement("MINAMT", Order = 3)]
        public string MINAMTStr
        {
            get
            {
                return this.MINAMT?.ToString();
            }
            set
            {
                this.MINAMT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 最大金额，decimal(15,2)，即整数最长13位，小数2位	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 最大金额，decimal(15,2)，即整数最长13位，小数2位 ,对应<see cref="MAXAMT"/>	非必输
        /// </summary>
        [XmlElement("MAXAMT", Order = 4)]
        public string MAXAMTStr
        {
            get
            {
                return this.MAXAMT?.ToString();
            }
            set
            {
                this.MAXAMT = value.TryConvert<decimal>();
            }
        }
    }
}
