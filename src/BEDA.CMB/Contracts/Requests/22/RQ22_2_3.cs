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
    /// 22.2.3.票据挂失止付定制查询设置维护查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_2_3 : CMBBase<RQINFO>, IRequest<RS22_2_3>
    {
        /// <summary>
        /// NTBLQMQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQMQY";
        /// <summary>
        /// 22.2.3.票据挂失止付定制查询设置维护查询请求内容
        /// </summary>
        public NTBLQWAUY1 NTBLQWAUY1 { get; set; }
    }
    /// <summary>
    /// 22.2.3.票据挂失止付定制查询设置维护查询请求内容
    /// </summary>
    public class NTBLQWAUY1
    {
        /// <summary>
        /// 经办起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 经办起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 经办结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 经办结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 金额低限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额高限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 续传键值	C(80)   续传时返回
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
