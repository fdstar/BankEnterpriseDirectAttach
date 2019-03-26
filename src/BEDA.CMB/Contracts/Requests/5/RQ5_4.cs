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
    /// 5.4.受益人查询来证（通知行）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ5_4 : CMBBase<RQINFO>, IRequest<RS5_4>
    {
        /// <summary>
        /// NTQRYLCB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCB";
        /// <summary>
        /// 5.4.受益人查询来证（通知行）请求内容
        /// </summary>
        public NTQRYLCBX1 NTQRYLCBX1 { get; set; }
    }
    /// <summary>
    /// 5.4.受益人查询来证（通知行）请求内容
    /// </summary>
    public class NTQRYLCBX1
    {
        /// <summary>
        /// 受益人帐号所在分行代码	C(2)	附录A.1
        /// </summary>
        public string BNFBBK { get; set; }
        /// <summary>
        /// 受益人帐号	C(1.35)
        /// </summary>
        public string BNFACC { get; set; }
        /// <summary>
        /// 起始日期	C(8)   起始日期和结束日期的间隔不能超过100天
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
        /// <summary>
        /// 最小金额	M   空时表示0.00
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最大金额	M   空时表示9999999999999.99
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 日期类型	C(1)	O：开证日期 C：有效期 空表示O
        /// </summary>
        public string DATFLG { get; set; }
    }
}
