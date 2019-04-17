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
    /// 23.19.取公司结算户历史交易请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_19 : CMBBase<RQINFO>, IRequest<RS23_19>
    {
        /// <summary>
        /// NTCPATRH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPATRH";
        /// <summary>
        /// 23.19.取公司结算户历史交易请求内容
        /// </summary>
        public NTCPATRHY NTCPATRHY { get; set; }
    }
    /// <summary>
    /// 23.19.取公司结算户历史交易请求内容
    /// </summary>
    public class NTCPATRHY
    {
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BGNDAT"/>
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
        /// 结束日期	D
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
        /// 交易金额 	M
        /// </summary>
        public decimal? LOWAMT { get; set; }
        /// <summary>
        /// 交易金额 	M
        /// </summary>
        public decimal? HGHAMT { get; set; }
    }
}
