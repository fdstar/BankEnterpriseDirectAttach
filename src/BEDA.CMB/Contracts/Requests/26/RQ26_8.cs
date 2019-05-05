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
    /// 26.8.综合查询接口请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_8 : CMBBase<RQINFO>, IRequest<RS26_8>
    {
        /// <summary>
        /// NTECKQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKQRY";
        /// <summary>
        /// 26.8.综合查询接口请求内容
        /// </summary>
        public NTECKQRYY NTECKQRYY { get; set; }
    }
    /// <summary>
    /// 26.8.综合查询接口请求内容
    /// </summary>
    public class NTECKQRYY
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
    }
}
