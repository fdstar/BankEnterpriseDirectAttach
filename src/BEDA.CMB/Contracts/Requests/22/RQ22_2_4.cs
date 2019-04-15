using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 22.2.4.票据挂失止付定制查询综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_2_4 : CMBBase<RQINFO>, IRequest<RS22_2_4>
    {
        /// <summary>
        /// NTBLQQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQQRY";
        /// <summary>
        /// 22.2.4.票据挂失止付定制查询综合查询请求内容
        /// </summary>
        public NTBLQQRYY1 NTBLQQRYY1 { get; set; }
    }
    /// <summary>
    /// 22.2.4.票据挂失止付定制查询综合查询请求内容
    /// </summary>
    public class NTBLQQRYY1
    {
        /// <summary>
        /// 查询账号分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 查询账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 票据金额最小	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 票据金额最大	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 定制查询起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 定制查询起始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 定制查询结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 定制查询结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 挂失止付标志	C(1)
        /// </summary>
        public string LSTFLG { get; set; }
        /// <summary>
        /// 票据到期日起始	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EXPBGN { get; set; }
        /// <summary>
        /// 票据到期日起始	D, 对应<see cref="EXPBGN"/>
        /// </summary>
        [XmlElement("EXPBGN")]
        public string EXPBGNStr
        {
            get
            {
                return this.EXPBGN?.ToString("yyyyMMdd");
            }
            set
            {
                this.EXPBGN = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPBGN = tmp;
                }
            }
        }
        /// <summary>
        /// 票据到期日结束	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EXPEND { get; set; }
        /// <summary>
        /// 票据到期日结束	D, 对应<see cref="EXPEND"/>
        /// </summary>
        [XmlElement("EXPEND")]
        public string EXPENDStr
        {
            get
            {
                return this.EXPEND?.ToString("yyyyMMdd");
            }
            set
            {
                this.EXPEND = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPEND = tmp;
                }
            }
        }
        /// <summary>
        /// 续传键值	C(80)   续传时返回
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
