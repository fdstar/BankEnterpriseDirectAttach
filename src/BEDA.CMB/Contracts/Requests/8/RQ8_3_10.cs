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
    /// 8.3.10.交易综合查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_10 : CMBBase<RQINFO>, IRequest<RS8_3_10>
    {
        /// <summary>
        /// NTQRYQDI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYQDI";
        /// <summary>
        /// 8.3.10.交易综合查询请求内容
        /// </summary>
        public NTWAUQDIX NTWAUQDIX { get; set; }
    }
    /// <summary>
    /// 8.3.10.交易综合查询请求内容
    /// </summary>
    public class NTWAUQDIX
    {
        /// <summary>
        /// 起始日期	D   查询日期范围不能大于100天
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
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
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
        /// 金额底限	M
        /// </summary>
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 金额上限	M
        /// </summary>
        public decimal? MAXAMT { get; set; }
    }
}
