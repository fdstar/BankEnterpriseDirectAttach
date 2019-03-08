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
    /// 3.20.4进口信用证开立通知查询请求主体
    /// </summary>
    public class V1_LCOPENNOTICEQUERYTRNRQ : IRequest<V1_LCOPENNOTICEQUERYTRNRS>
    {
        /// <summary>
        /// 3.20.4进口信用证开立通知查询请求主体
        /// </summary>
        public LCOPENNOTICEQUERYTRNRQ LCOPENNOTICEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.20.4进口信用证开立通知查询请求主体
    /// </summary>
    public class LCOPENNOTICEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.20.4进口信用证开立通知查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCOPENNOTICEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.20.4进口信用证开立通知查询请求内容
    /// </summary>
    public class LCOPENNOTICEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 开始时间YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 开始时间YYYY-MM-DD, 对应<see cref="STARTDATE"/>	必输 
        /// </summary>
        [XmlElement("STARTDATE", Order = 2)]
        public string STARTDATEStr
        {
            get
            {
                return this.STARTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STARTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 结束时间YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDATE { get; set; }
        /// <summary>
        /// 结束时间YYYY-MM-DD, 对应<see cref="ENDDATE"/>	必输 
        /// </summary>
        [XmlElement("ENDDATE", Order = 3)]
        public string ENDDATEStr
        {
            get
            {
                return this.ENDDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDATE = tmp;
                }
            }
        }
    }
}
