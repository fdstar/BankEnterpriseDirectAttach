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
    /// 3.12.7.7定活互转智能定期存款—明细查询请求主体
    /// </summary>
    public class V1_QUERYINTELLIGENTTIMEDETAILTRNRQ : IRequest<V1_QUERYINTELLIGENTTIMEDETAILTRNRS>
    {
        /// <summary>
        /// 3.12.7.7定活互转智能定期存款—明细查询请求主体
        /// </summary>
        public QUERYINTELLIGENTTIMEDETAILTRNRQ QUERYINTELLIGENTTIMEDETAILTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.7.7定活互转智能定期存款—明细查询请求主体
    /// </summary>
    public class QUERYINTELLIGENTTIMEDETAILTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.7.7定活互转智能定期存款—明细查询请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public QUERYINTELLIGENTTIMEDETAILTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.7.7定活互转智能定期存款—明细查询请求内容
    /// </summary>
    public class QUERYINTELLIGENTTIMEDETAILTRN_RQBODY
    {
        /// <summary>
        /// PAGE查询页码，不输默认第1页，必输
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 签约智能定期账号	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string FIXEDACCOUNTNO { get; set; }
        /// <summary>
        /// 最小金额	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? MINAMOUNT { get; set; }
        /// <summary>
        /// 最小金额 对应<see cref="MINAMOUNT"/>	非必输
        /// </summary>
        [XmlElement("MINAMOUNT", Order = 2)]
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
        /// 最大金额 对应<see cref="MAXAMOUNT"/>	非必输
        /// </summary>
        [XmlElement("MAXAMOUNT", Order = 3)]
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
        /// 起始时间 格式必须为YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime STARTDATE { get; set; }
        /// <summary>
        /// 起始时间 格式必须为YYYY-MM-DD,对应<see cref="STARTDATE"/> 必输
        /// </summary>
        [XmlElement("STARTDATE", Order = 4)]
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
        /// 截止时间 格式必须为YYYY-MM-DD，截止时间必须大于起始时间 必输
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDATE { get; set; }
        /// <summary>
        /// 截止时间 格式必须为YYYY-MM-DD，截止时间必须大于起始时间,对应<see cref="ENDDATE"/> 必输
        /// </summary>
        [XmlElement("ENDDATE", Order = 5)]
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