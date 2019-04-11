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
    /// 18.8.查询账单列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ18_8 : CMBBase<RQINFO>, IRequest<RS18_8>
    {
        /// <summary>
        /// SDKSWPKGLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKSWPKGLST";
        /// <summary>
        /// 18.8.查询账单列表请求内容
        /// </summary>
        public SWPKGLSTX1 SWPKGLSTX1 { get; set; }
    }
    /// <summary>
    /// 18.8.查询账单列表请求内容
    /// </summary>
    public class SWPKGLSTX1
    {
        /// <summary>
        /// 行内账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 境外账号	C(35)
        /// </summary>
        public string ACTNBR { get; set; }
        /// <summary>
        /// 开始起息日	D   查询日期范围不能超过7天
        /// </summary>
        [XmlIgnore]
        public DateTime BGNDTE { get; set; }
        /// <summary>
        /// 开始起息日	D, 对应<see cref="BGNDTE"/>
        /// </summary>
        [XmlElement("BGNDTE")]
        public string BGNDTEStr
        {
            get
            {
                return this.BGNDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BGNDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 结束起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDTE { get; set; }
        /// <summary>
        /// 结束起息日	D, 对应<see cref="ENDDTE"/>
        /// </summary>
        [XmlElement("ENDDTE")]
        public string ENDDTEStr
        {
            get
            {
                return this.ENDDTE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTE = tmp;
                }
            }
        }
    }
}
