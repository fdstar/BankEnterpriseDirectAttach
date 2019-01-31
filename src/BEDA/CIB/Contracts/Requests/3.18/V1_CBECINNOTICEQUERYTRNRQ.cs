using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
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
    /// 3.18.10跨境电商收汇通知查询请求主体
    /// </summary>
    public class V1_CBECINNOTICEQUERYTRNRQ : IRequest<V1_CBECINNOTICEQUERYTRNRS>
    {
        /// <summary>
        /// 3.18.10跨境电商收汇通知查询请求主体
        /// </summary>
        public CBECINNOTICEQUERYTRNRQ CBECINNOTICEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.18.10跨境电商收汇通知查询请求主体
    /// </summary>
    public class CBECINNOTICEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.18.10跨境电商收汇通知查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECINNOTICEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.18.10跨境电商收汇通知查询请求内容
    /// </summary>
    public class CBECINNOTICEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 货币种类	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 业务日期查询范围 开始时间YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime BEGINDATE { get; set; }
        /// <summary>
        /// 业务日期查询范围 开始时间YYYY-MM-DD, 对应<see cref="BEGINDATE"/>	必输 
        /// </summary>
        [XmlElement("BEGINDATE", Order = 2)]
        public string BEGINDATEStr
        {
            get
            {
                return this.BEGINDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGINDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 业务日期查询范围 结束时间YYYY-MM-DD 非必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDATE { get; set; }
        /// <summary>
        /// 业务日期查询范围 结束时间YYYY-MM-DD, 对应<see cref="ENDDATE"/>	非必输 
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
        /// <summary>
        /// 最小金额(汇款金额)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最小金额(汇款金额), 对应<see cref="MINAMT"/>	非必输 
        /// </summary>
        [XmlElement("MINAMT", Order = 4)]
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
        /// 最多金额(汇款金额)	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 最多金额(汇款金额), 对应<see cref="MAXAMT"/>	非必输 
        /// </summary>
        [XmlElement("MAXAMT", Order = 5)]
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
