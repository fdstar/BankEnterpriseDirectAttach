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
    /// 19.2.14.票据背书信息查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_2_14 : CMBBase<RQINFO>, IRequest<RS19_2_14>
    {
        /// <summary>
        /// SDKCUSWRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKCUSWRT";
        /// <summary>
        /// 19.2.14.票据背书信息查询请求内容
        /// </summary>
        public NTCUSWRTX NTCUSWRTX { get; set; }
    }
    /// <summary>
    /// 19.2.14.票据背书信息查询请求内容
    /// </summary>
    public class NTCUSWRTX
    {
        /// <summary>
        /// 票据流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime TRSDTA { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="TRSDTA"/>
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
    }
}
