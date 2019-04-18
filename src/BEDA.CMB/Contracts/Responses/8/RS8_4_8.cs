using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 8.4.8.产生通知响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSMANTF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMANTF";
        /// <summary>
        /// 8.4.8.产生通知响应内容
        /// </summary>
        public NTSMANTFZ NTSMANTFZ { get; set; }
    }
    /// <summary>
    /// 8.4.8.产生通知响应内容
    /// </summary>
    public class NTSMANTFZ
    {
        /// <summary>
        /// 通知日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime INFDAT { get; set; }
        /// <summary>
        /// 通知日期	D, 对应<see cref="INFDAT"/>
        /// </summary>
        [XmlElement("INFDAT")]
        public string INFDATStr
        {
            get
            {
                return this.INFDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INFDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日期	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
