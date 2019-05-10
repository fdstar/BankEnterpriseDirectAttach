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
    /// 32.5.国际信用证单笔查询-按业务参考号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ32_5 : CMBBase<RQINFO>, IRequest<RS32_5>
    {
        /// <summary>
        /// NTQRYLCY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCY";
        /// <summary>
        /// 32.5.国际信用证单笔查询-按业务参考号请求内容
        /// </summary>
        public NTQRYLCYX1 NTQRYLCYX1 { get; set; }
    }
    /// <summary>
    /// 32.5.国际信用证单笔查询-按业务参考号请求内容
    /// </summary>
    public class NTQRYLCYX1
    {
        /// <summary>
        /// 业务代码	C(6)    开证经办‘N05020’，修改申请经办‘N05030’
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 起始日期	C(8)   日期区间只能查7天， 起始日期不能早于当前日期三个月
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	C(8), 对应<see cref="BGNDAT"/>
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
        /// 结束日期	C(8)
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	C(8), 对应<see cref="ENDDAT"/>
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
