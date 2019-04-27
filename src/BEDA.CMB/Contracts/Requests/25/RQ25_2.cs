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
    /// 25.2.查询待还款信息列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ25_2 : CMBBase<RQINFO>, IRequest<RS25_2>
    {
        /// <summary>
        /// NTCDTRPY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTRPY";
        /// <summary>
        /// 25.2.查询待还款信息列表请求内容
        /// </summary>
        public NTCDTRPYX1 NTCDTRPYX1 { get; set; }
    }
    /// <summary>
    /// 25.2.查询待还款信息列表请求内容
    /// </summary>
    public class NTCDTRPYX1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 起始日期	D   不输入则查询当天日期
        /// </summary>
        [XmlIgnore]
        public DateTime? BGNDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BGNDAT"/>
        /// </summary>
        [XmlElement("BGNDAT")]
        public string BGNDATStr
        {
            get
            {
                return this.BGNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BGNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结束日期	D   不输入则查询当天日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 贷款业务号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
