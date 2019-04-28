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
    /// 25.5.还款维护综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ25_5 : CMBBase<RQINFO>, IRequest<RS25_5>
    {
        /// <summary>
        /// NTQRYCDT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYCDT";
        /// <summary>
        /// 25.5.还款维护综合查询请求内容
        /// </summary>
        public NTQRYCDTY1 NTQRYCDTY1 { get; set; }
    }
    /// <summary>
    /// 25.5.还款维护综合查询请求内容
    /// </summary>
    public class NTQRYCDTY1
    {
        /// <summary>
        /// 起始日期	D   起始日期和结束日期的间隔不能超过100天
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
        /// 日期标志	C(1)	A：经办日 B：期望日
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
