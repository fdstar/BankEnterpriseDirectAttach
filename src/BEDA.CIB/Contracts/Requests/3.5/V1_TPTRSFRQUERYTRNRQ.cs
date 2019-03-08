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
    /// 3.5.5第三方存管交易查询请求主体
    /// </summary>
    public class V1_TPTRSFRQUERYTRNRQ : IRequest<V1_TPTRSFRQUERYTRNRS>
    {
        /// <summary>
        /// 3.5.5第三方存管交易查询请求主体
        /// </summary>
        public TPTRSFRQUERYTRNRQ TPTRSFRQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.5第三方存管交易查询请求主体
    /// </summary>
    public class TPTRSFRQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.5第三方存管交易查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public TPTRSFRQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.5第三方存管交易查询请求内容
    /// </summary>
    public class TPTRSFRQUERYTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，每页100笔，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 版本控制，非必输；用于兼容旧版本接口1.0 -- 旧版本, 2.0 -- 新版本,默认1.0版本	非必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string VERSION { get; set; }
        /// <summary>
        /// 非必输，默认普通存管 0-普通存管，1-融资融券 （不管版本号是否输入版本号，默认2.0）， 2-银衍互转 （不管版本号是否输入版本号，默认2.0） 	非必输，（当做融资融券、银衍互转是必输）
        /// </summary>
        [XmlElement(Order = 1)]
        public string TRUSTEETYPE { get; set; }
        /// <summary>
        /// 查询账户代号，最长32位，必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 操作标识 1转账明细（当日历史都能查）2历史资金明细（交易轧差）必输
        /// </summary>
        [XmlElement(Order = 11)]
        public int OPERTYPE { get; set; } = 1;
        /// <summary>
        /// 查询对账单时的查询月份	非必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string MONTH { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 起始日期YYYY-MM-DD ,对应<see cref="DTSTART"/>	必输
        /// </summary>
        [XmlElement("DTSTART", Order = 13)]
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
        [XmlElement("DTEND", Order = 14)]
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
    }
}
