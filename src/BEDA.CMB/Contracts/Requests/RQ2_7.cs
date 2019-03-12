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
    /// 2.7.查询电子回单信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_7 : CMBBase<RQINFO>, IRequest<RS2_7>
    {
        /// <summary>
        /// SDKCSFDFBRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCSFDFBRT";
        /// <summary>
        /// 2.7.查询电子回单信息请求内容
        /// </summary>
        public CSRRCFDFY0 CSRRCFDFY0 { get; set; }
    }
    /// <summary>
    /// 2.7.查询电子回单信息请求内容
    /// </summary>
    public class CSRRCFDFY0
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 起始日期	D   日期范围不能大于一个月
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D   日期范围不能大于一个月
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
        /// 打印标志	C(1)	1:未打印 2:已打印
        /// </summary>
        public int RRCFLG { get; set; }
        /// <summary>
        /// 最大金额	M
        /// </summary>
        public decimal? BEGAMT { get; set; }
        /// <summary>
        /// 最大金额	M
        /// </summary>
        public decimal? ENDAMT { get; set; }
        /// <summary>
        /// 回单代码	C(8)
        /// </summary>
        public string RRCCOD { get; set; }
    }
}
