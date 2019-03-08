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
    /// 3.19.5跨境资金池集中结汇交易明细查询请求主体
    /// </summary>
    public class V1_CBCPEXCHNGTRADEQUERYTRNRQ : IRequest<V1_CBCPEXCHNGTRADEQUERYTRNRS>
    {
        /// <summary>
        /// 3.19.5跨境资金池集中结汇交易明细查询请求主体
        /// </summary>
        public CBCPEXCHNGTRADEQUERYTRNRQ CBCPEXCHNGTRADEQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.19.5跨境资金池集中结汇交易明细查询请求主体
    /// </summary>
    public class CBCPEXCHNGTRADEQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.19.5跨境资金池集中结汇交易明细查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPEXCHNGTRADEQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.19.5跨境资金池集中结汇交易明细查询请求内容
    /// </summary>
    public class CBCPEXCHNGTRADEQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 活期账户代号，18位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 开始时间 YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 开始时间 YYYY-MM-DD, 对应<see cref="STARTDATE"/>	必输 
        /// </summary>
        [XmlElement("STARTDATE", Order = 1)]
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
        /// 结束时间 YYYY-MM-DD	必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDATE { get; set; }
        /// <summary>
        /// 结束时间 YYYY-MM-DD, 对应<see cref="ENDDATE"/>	必输 
        /// </summary>
        [XmlElement("ENDDATE", Order = 2)]
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
        /// 最小金额	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAMOUNT { get; set; }
        /// <summary>
        /// 最小金额, 对应<see cref="MINAMOUNT"/>	非必输 
        /// </summary>
        [XmlElement("MINAMOUNT", Order = 3)]
        public string MINAMOUNTStr
        {
            get
            {
                return this.MINAMOUNT?.ToString();
            }
            set
            {
                this.MINAMOUNT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 最大金额	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MAXAMOUNT { get; set; }
        /// <summary>
        /// 最大金额, 对应<see cref="MAXAMOUNT"/>	非必输 
        /// </summary>
        [XmlElement("MAXAMOUNT", Order = 4)]
        public string MAXAMOUNTStr
        {
            get
            {
                return this.MAXAMOUNT?.ToString();
            }
            set
            {
                this.MAXAMOUNT = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 交易状态，空查询全部 0-交易成功 1-交易失败 非必输
        /// </summary>
        [XmlIgnore]
        public int? TRADESTATUS { get; set; }
        /// <summary>
        /// 交易状态，空查询全部 0-交易成功 1-交易失败, 对应<see cref="TRADESTATUS"/>	非必输 
        /// </summary>
        [XmlElement("TRADESTATUS", Order = 5)]
        public string TRADESTATUSStr
        {
            get
            {
                return this.TRADESTATUS?.ToString();
            }
            set
            {
                this.TRADESTATUS = value.TryConvert<int>();
            }
        }
        /// <summary>
        /// 排序，空不排序 0-升序 1-降序 非必输
        /// </summary>
        [XmlIgnore]
        public int? ORDER { get; set; }
        /// <summary>
        /// 排序，空不排序 0-升序 1-降序, 对应<see cref="ORDER"/>	非必输 
        /// </summary>
        [XmlElement("ORDER", Order = 6)]
        public string ORDERStr
        {
            get
            {
                return this.ORDER?.ToString();
            }
            set
            {
                this.ORDER = value.TryConvert<int>();
            }
        }
        /// <summary>
        /// 收款账号	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string TOACCTNO { get; set; }
    }
}
