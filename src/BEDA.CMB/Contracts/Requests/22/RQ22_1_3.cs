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
    /// 22.1.3.贴现申请清单综合查询列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_1_3 : CMBBase<RQINFO>, IRequest<RS22_1_3>
    {
        /// <summary>
        /// NTBSCQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBSCQRY";
        /// <summary>
        /// 22.1.3.贴现申请清单综合查询列表请求内容
        /// </summary>
        public NTBSCQRYY1 NTBSCQRYY1 { get; set; }
    }
    /// <summary>
    /// 22.1.3.贴现申请清单综合查询列表请求内容
    /// </summary>
    public class NTBSCQRYY1
    {
        /// <summary>
        /// 账号分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 贴现总金额最小	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 贴现总金额最大	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 贴现申请起始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 贴现申请起始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 贴现申请结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 贴现申请结束日期	D, 对应<see cref="ENDDAT"/>
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
        /// 票据张数	F(5,0)
        /// </summary>
        public int? BILCNT { get; set; }
        /// <summary>
        /// 参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 申请状态	C（1）
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 续传键值	A(80)
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
