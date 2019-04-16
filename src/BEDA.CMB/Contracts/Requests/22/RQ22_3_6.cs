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
    /// 22.3.6.票据信息综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_3_6 : CMBBase<RQINFO>, IRequest<RS22_3_6>
    {
        /// <summary>
        /// NTBILQRL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILQRL";
        /// <summary>
        /// 22.3.6.票据信息综合查询请求内容
        /// </summary>
        public NTBILQRLY1 NTBILQRLY1 { get; set; }
    }
    /// <summary>
    /// 22.3.2.业务经办挑票查询请求内容
    /// </summary>
    public class NTBILQRLY1
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
        /// 银行管理类型	C(1)    1.仅信息 2.银行保管
        /// </summary>
        public string MNGTYP { get; set; }
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
        /// 撤销托管日期起	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OUBDAT { get; set; }
        /// <summary>
        /// 撤销托管日期起	D, 对应<see cref="OUBDAT"/>
        /// </summary>
        [XmlElement("OUBDAT")]
        public string OUBDATStr
        {
            get
            {
                return this.OUBDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OUBDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OUBDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 撤销托管日期止	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OUEDAT { get; set; }
        /// <summary>
        /// 撤销托管日期止	D, 对应<see cref="OUEDAT"/>
        /// </summary>
        [XmlElement("OUEDAT")]
        public string OUEDATStr
        {
            get
            {
                return this.OUEDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OUEDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OUEDAT = tmp;
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
        /// 票据种类	C(1)    0.银行承兑票据 1.商业承兑票据
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 应收应付标志	C(1)    1.应收 2.应付
        /// </summary>
        public string PAYFLG { get; set; }
        /// <summary>
        /// 票据类型	C(1)    0.纸质汇票；1.电子商业汇票；
        /// </summary>
        public string BILKND { get; set; }
        /// <summary>
        /// 票据标示号	C(20)
        /// </summary>
        public string BILSYN { get; set; }
        /// <summary>
        /// 票据状态	C(2)
        /// </summary>
        public string BILSTS { get; set; }
        /// <summary>
        /// 续传键值	C(80)
        /// </summary>
        public string CNTKEY { get; set; }
    }
}
