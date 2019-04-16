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
    /// 23.5.取公司卡历史交易请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_5 : CMBBase<RQINFO>, IRequest<RS23_5>
    {
        /// <summary>
        /// NTCPRTRH
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRTRH";
        /// <summary>
        /// 23.5.取公司卡历史交易请求内容
        /// </summary>
        public NTCPRTRHY NTCPRTRHY { get; set; }
    }
    /// <summary>
    /// 23.5.取公司卡历史交易请求内容
    /// </summary>
    public class NTCPRTRHY
    {
        /// <summary>
        /// 公司卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
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
        /// 交易金额下限 	M
        /// </summary>
        public decimal? LOWAMT { get; set; }
        /// <summary>
        /// 交易金额上限 	M
        /// </summary>
        public decimal? HGHAMT { get; set; }
        /// <summary>
        /// 续传     	C(40)
        /// </summary>
        public string CTNKEY { get; set; }
    }
}
