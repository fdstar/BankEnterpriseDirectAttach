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
    /// 8.11.2.银期转账直连综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_11_2 : CMBBase<RQINFO>, IRequest<RS8_11_2>
    {
        /// <summary>
        /// NTBTFDQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBTFDQY";
        /// <summary>
        /// 8.11.2.银期转账直连综合查询请求内容
        /// </summary>
        public NTBTFDQYX NTBTFDQYX { get; set; }
    }
    /// <summary>
    /// 8.11.2.银期转账直连综合查询请求内容
    /// </summary>
    public class NTBTFDQYX
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 开始日期	D   	开始日期与结束日期间隔不能超过7天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 结束日期	D   开始日期与结束日期间隔不能超过7天
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
        /// 金额下限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额上限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
    }
}
