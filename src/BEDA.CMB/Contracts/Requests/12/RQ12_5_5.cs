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
    /// 12.5.5.汇入汇款款项确认信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_5_5 : CMBBase<RQINFO>, IRequest<RS12_5_5>
    {
        /// <summary>
        /// NTIRAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRAQRY";
        /// <summary>
        /// 12.5.5.汇入汇款款项确认信息查询请求内容
        /// </summary>
        public NTIRAQRYY NTIRAQRYY { get; set; }
    }
    /// <summary>
    /// 12.5.5.汇入汇款款项确认信息查询请求内容
    /// </summary>
    public class NTIRAQRYY
    {
        /// <summary>
        /// 起始日期	D   起始时间与结束时间相差不能超过30天
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
        /// 结束日期	D
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
        /// 起始金额	M
        /// </summary>
        public decimal? STRAMT { get; set; }
        /// <summary>
        /// 结束金额	M
        /// </summary>
        public decimal? ENDAMT { get; set; }
        /// <summary>
        /// 返回结果	C(30)
        /// C主动撤销
        /// D过期撤销
        /// R否决
        /// Q部分成功
        /// S成功
        /// F失败
        /// 空时查全部； 可组合输入，例如输入RS查询否决和成功的交易，不同组合之间无顺序要求，如果输入错误的值则返回结果为空
        /// </summary>
        public string RTNSTR { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
    }
}
