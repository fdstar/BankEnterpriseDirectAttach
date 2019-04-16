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
    /// 22.3.2.业务经办挑票查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_3_2 : CMBBase<RQINFO>, IRequest<RS22_3_2>
    {
        /// <summary>
        /// NTBILOQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILOQY";
        /// <summary>
        /// 22.3.2.业务经办挑票查询请求内容
        /// </summary>
        public NTBILOQYY1 NTBILOQYY1 { get; set; }
    }
    /// <summary>
    /// 22.3.2.业务经办挑票查询请求内容
    /// </summary>
    public class NTBILOQYY1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 申请账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 交易代码	C(2)
        /// </summary>
        public string TRNTYP { get; set; }
        /// <summary>
        /// 托管日期起	D
        /// </summary>
        [XmlIgnore]
        public DateTime? INBDAT { get; set; }
        /// <summary>
        /// 托管日期起	D, 对应<see cref="INBDAT"/>
        /// </summary>
        [XmlElement("INBDAT")]
        public string INBDATStr
        {
            get
            {
                return this.INBDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.INBDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 托管日期止	D
        /// </summary>
        [XmlIgnore]
        public DateTime? INEDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="INEDAT"/>
        /// </summary>
        [XmlElement("INEDAT")]
        public string INEDATStr
        {
            get
            {
                return this.INEDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.INEDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 出票日起	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPBDAT { get; set; }
        /// <summary>
        /// 出票日起	D, 对应<see cref="OPBDAT"/>
        /// </summary>
        [XmlElement("OPBDAT")]
        public string OPBDATStr
        {
            get
            {
                return this.OPBDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPBDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 出票日止	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPEDAT { get; set; }
        /// <summary>
        /// 出票日止	D, 对应<see cref="OPEDAT"/>
        /// </summary>
        [XmlElement("OPEDAT")]
        public string OPEDATStr
        {
            get
            {
                return this.OPEDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPEDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日起	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EDBDAT { get; set; }
        /// <summary>
        /// 到期日起	D, 对应<see cref="EDBDAT"/>
        /// </summary>
        [XmlElement("EDBDAT")]
        public string EDBDATStr
        {
            get
            {
                return this.EDBDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EDBDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EDBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日止	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EDEDAT { get; set; }
        /// <summary>
        /// 到期日止	D, 对应<see cref="EDEDAT"/>
        /// </summary>
        [XmlElement("EDEDAT")]
        public string EDEDATStr
        {
            get
            {
                return this.EDEDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EDEDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EDEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 最小票面金额	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最大票面金额	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 票据种类	C(1)
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据标示号	C(20)
        /// </summary>
        public string BILSYN { get; set; }
        /// <summary>
        /// 续传键值	C(80)
        /// </summary>
        public string CNTKEY { get; set; }
    }
}
