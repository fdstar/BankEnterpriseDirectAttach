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
    /// 18.5.境外账户维护综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_5 : CMBBase<RQINFO>, IRequest<RS18_5>
    {
        /// <summary>
        /// NTLSTCAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLSTCAC";
        /// <summary>
        /// 18.5.境外账户维护综合查询请求内容
        /// </summary>
        public NTWAUCACY NTWAUCACY { get; set; }
    }
    /// <summary>
    /// 18.5.境外账户维护综合查询请求内容
    /// </summary>
    public class NTWAUCACY
    {
        /// <summary>
        /// 经办起始日期	D   日期范围不能超过100天
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 维护类型	C(3)    OPR:增加 UPD:更新 DLT:删除
        /// </summary>
        public string MNTTYP { get; set; }
    }
}
