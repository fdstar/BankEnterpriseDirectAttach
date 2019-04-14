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
    /// 19.2.18.票据托收查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_18 : CMBBase<RQINFO>, IRequest<RS19_2_18>
    {
        /// <summary>
        /// SDKDRFRCV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKDRFRCV";
        /// <summary>
        /// 19.2.18.票据托收查询请求内容
        /// </summary>
        public NTDRFRCVX NTDRFRCVX { get; set; }
    }
    /// <summary>
    /// 19.2.18.票据托收查询请求内容
    /// </summary>
    public class NTDRFRCVX
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
    }
}
