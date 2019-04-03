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
    /// 20.4.联动支付综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ20_4 : CMBBase<RQINFO>, IRequest<RS20_4>
    {
        /// <summary>
        /// NTQRYLKP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYLKP";
        /// <summary>
        /// 20.4.联动支付综合查询请求内容
        /// </summary>
        public NTQRYLKPY1 NTQRYLKPY1 { get; set; }
    }
    /// <summary>
    /// 20.4.联动支付综合查询请求内容
    /// </summary>
    public class NTQRYLKPY1
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
        /// 最小交易金额	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 最大交易金额	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string REFKEY { get; set; }
        /// <summary>
        /// 经办用户	Z(30)
        /// </summary>
        public string OPRLGN { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	A.6 业务处理结果  空表示查询所有结果的数据
        /// </summary>
        public string RTNFLG { get; set; }
    }
}
