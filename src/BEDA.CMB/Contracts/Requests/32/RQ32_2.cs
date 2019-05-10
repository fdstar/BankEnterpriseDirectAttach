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
    /// 32.2.国际信用证综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ32_2 : CMBBase<RQINFO>, IRequest<RS32_2>
    {
        /// <summary>
        /// NTQRYLCD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCD";
        /// <summary>
        /// 32.2.国际信用证综合查询请求内容
        /// </summary>
        public NTQRYLCDY1 NTQRYLCDY1 { get; set; }
    }
    /// <summary>
    /// 32.2.国际信用证综合查询请求内容
    /// </summary>
    public class NTQRYLCDY1
    {
        /// <summary>
        /// 业务代码	C(6)    开证经办‘N05020’，修改申请经办‘N05030’
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 起始日期	C(8)   日期期间只能查7天，直连校验
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
