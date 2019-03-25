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
    /// 5.2.申请人查询开证申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ5_2 : CMBBase<RQINFO>, IRequest<RS5_2>
    {
        /// <summary>
        /// NTQRYLCA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLCA";
        /// <summary>
        /// 5.2.申请人查询开证申请请求内容
        /// </summary>
        public NTQRYLCAX1 NTQRYLCAX1 { get; set; }
    }
    /// <summary>
    /// 5.2.申请人查询开证申请请求内容
    /// </summary>
    public class NTQRYLCAX1
    {
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
        /// 日期类型	C(1)	A：经办日期；B：期望日期 C：按到期日    空表示A
        /// </summary>
        public string DATFLG { get; set; }
        /// <summary>
        /// 最小金额	M   空时表示0.00
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最大金额	M   空时表示9999999999999.99
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 请求状态	C(30)	附录A.5
        /// </summary>
        public string AUTSTR { get; set; }
        /// <summary>
        /// 业务参考号	C (30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
