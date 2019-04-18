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
    /// 8.3.9.当日委托撤单请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_9 : CMBBase<RQINFO>, IRequest<RS8_3_9>
    {
        /// <summary>
        /// NTQDICAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDICAL";
        /// <summary>
        /// 8.3.9.当日委托撤单请求内容
        /// </summary>
        public NTQDICALX NTQDICALX { get; set; }
    }
    /// <summary>
    /// 8.3.9.当日委托撤单请求内容
    /// </summary>
    public class NTQDICALX
    {
        /// <summary>
        /// 委托日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ORDDAT { get; set; }
        /// <summary>
        /// 委托日期	D, 对应<see cref="ORDDAT"/>
        /// </summary>
        [XmlElement("ORDDAT")]
        public string ORDDATStr
        {
            get
            {
                return this.ORDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ORDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 委托合同	C(8)
        /// </summary>
        public string ORDCTR { get; set; }
    }
}
