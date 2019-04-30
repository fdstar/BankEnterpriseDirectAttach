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
    /// 26.5.支付状态查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ26_5 : CMBBase<RQINFO>, IRequest<RS26_5>
    {
        /// <summary>
        /// NTECKTQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKTQY";
        /// <summary>
        /// 26.5.支付状态查询请求内容
        /// </summary>
        public NTECKTQYY NTECKTQYY { get; set; }
    }
    /// <summary>
    /// 26.5.支付状态查询请求内容
    /// </summary>
    public class NTECKTQYY
    {
        /// <summary>
        /// 起始日期	D   起始结束日期不能超过7天
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 起始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
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
        /// 结束日期	D   开始日期和结束日期必须早于当日
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
        /// 支票号码	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
    }
}
