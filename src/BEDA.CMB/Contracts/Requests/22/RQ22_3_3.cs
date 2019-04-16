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
    /// 22.3.3.票据查询查复请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_3_3 : CMBBase<RQINFO>, IRequest<RS22_3_3>
    {
        /// <summary>
        /// NTBILRQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILRQY";
        /// <summary>
        /// 22.3.3.票据查询查复请求内容
        /// </summary>
        public NTBILRQYY1 NTBILRQYY1 { get; set; }
    }
    /// <summary>
    /// 22.3.3.票据查询查复请求内容
    /// </summary>
    public class NTBILRQYY1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
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
