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
    /// 3.13.7扣税流水查询请求主体
    /// </summary>
    public class V1_CHINAMOBILETAXQUERYTRNRQ : IRequest<V1_CHINAMOBILETAXQUERYTRNRS>
    {
        /// <summary>
        /// 3.13.7扣税流水查询请求主体
        /// </summary>
        public CHINAMOBILETAXQUERYTRNRQ CHINAMOBILETAXQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.13.7扣税流水查询请求主体
    /// </summary>
    public class CHINAMOBILETAXQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.13.7扣税流水查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CHINAMOBILETAXQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.13.7扣税流水查询请求内容
    /// </summary>
    public class CHINAMOBILETAXQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页号，表示从第几页开始查询默认1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 付款人账户，32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd(必输) 必须为7天内的日期时间
        /// </summary>
        [XmlIgnore]
        public DateTime DTSTART { get; set; }
        /// <summary>
        /// 开始时间 格式：yyyy-MM-dd 必须为7天内的日期时间 ,对应<see cref="DTSTART"/>	必输
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
        /// 结束时间 格式：yyyy-MM-dd(必输)
        /// </summary>
        [XmlIgnore]
        public DateTime DTEND { get; set; }
        /// <summary>
        /// 结束时间 格式：yyyy-MM-dd ,对应<see cref="DTEND"/>	必输
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
    }
}
