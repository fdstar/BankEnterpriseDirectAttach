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
    /// 3.20.9进口信用证即期付款/远期付款通知查询请求主体
    /// </summary>
    public class V1_LCPAYNOTICEQUERYTRNRQ : IRequest<V1_LCPAYNOTICEQUERYTRNRS>
    {
        /// <summary>
        /// 3.20.9进口信用证即期付款/远期付款通知查询请求主体
        /// </summary>
        public LCPAYNOTICEQUERYTRNRQ LCPAYNOTICEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.20.9进口信用证即期付款/远期付款通知查询请求主体
    /// </summary>
    public class LCPAYNOTICEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.20.9进口信用证即期付款/远期付款通知查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCPAYNOTICEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.20.9进口信用证即期付款/远期付款通知查询请求内容
    /// </summary>
    public class LCPAYNOTICEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 查询业务类型  必输
        /// 0-即期付款
        /// 1-远期付款
        /// </summary>
        [XmlElement(Order = 0)]
        public int QUERYTYPE { get; set; }
        /// <summary>
        /// 信用证号	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string LCREFNO { get; set; }
        /// <summary>
        /// 到单号	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string BPREFNO { get; set; }
        /// <summary>
        /// 开始时间YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 开始时间YYYY-MM-DD, 对应<see cref="STARTDATE"/>	必输 
        /// </summary>
        [XmlElement("STARTDATE", Order = 3)]
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
        [XmlElement("ENDDATE", Order = 4)]
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
