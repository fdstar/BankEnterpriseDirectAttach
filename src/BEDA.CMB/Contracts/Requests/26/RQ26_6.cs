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
    /// 26.6.支票管理查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_6 : CMBBase<RQINFO>, IRequest<RS26_6>
    {
        /// <summary>
        /// NTECKLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKLST";
        /// <summary>
        /// 26.6.支票管理查询请求内容
        /// </summary>
        public NTECKLSTY NTECKLSTY { get; set; }
    }
    /// <summary>
    /// 26.6.支票管理查询请求内容
    /// </summary>
    public class NTECKLSTY
    {
        /// <summary>
        /// 起始日期	D   起始结束日期不能超过7天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 结束日期	D   开始日期和结束日期必须早于当日
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 付款账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 支票号码	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
    }
}
