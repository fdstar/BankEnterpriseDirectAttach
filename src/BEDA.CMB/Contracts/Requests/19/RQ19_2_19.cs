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
    /// 19.2.19.票据退票查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_19 : CMBBase<RQINFO>, IRequest<RS19_2_19>
    {
        /// <summary>
        /// SDKDRFQUT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKDRFQUT";
        /// <summary>
        /// 19.2.19.票据退票查询请求内容
        /// </summary>
        public NTDRFQUTX NTDRFQUTX { get; set; }
    }
    /// <summary>
    /// 19.2.19.票据退票查询请求内容
    /// </summary>
    public class NTDRFQUTX
    {
        /// <summary>
        /// 起始托收到账日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTA { get; set; }
        /// <summary>
        /// 起始托收到账日期	D, 对应<see cref="TRSDTA"/>
        /// </summary>
        [XmlElement("TRSDTA")]
        public string TRSDTAStr
        {
            get
            {
                return this.TRSDTA.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 结束托收到账日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime FINDTA { get; set; }
        /// <summary>
        /// 结束托收到账日期	D, 对应<see cref="FINDTA"/>
        /// </summary>
        [XmlElement("FINDTA")]
        public string FINDTAStr
        {
            get
            {
                return this.FINDTA.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FINDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 完成	C(1)	Y或空 退票状态（必输，单选）
        /// </summary>
        public string QUTFLG { get; set; }
        /// <summary>
        /// 退票中	C(1)	Y或空 退票状态（必输，单选）
        /// </summary>
        public string GEPFLG { get; set; }
    }
}
