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
    /// 9.6.交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ9_6 : CMBBase<RQINFO>, IRequest<RS9_6>
    {
        /// <summary>
        /// NTNETDZT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZT";
        /// <summary>
        /// 9.6.交易查询请求内容
        /// </summary>
        public NTNETDZTY1 NTNETDZTY1 { get; set; }
    }
    /// <summary>
    /// 9.6.交易查询请求内容
    /// </summary>
    public class NTNETDZTY1
    {
        /// <summary>
        /// 起始交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDT1 { get; set; }
        /// <summary>
        /// 起始交易日期	D, 对应<see cref="TRSDT1"/>
        /// </summary>
        [XmlElement("TRSDT1")]
        public string TRSDT1Str
        {
            get
            {
                return this.TRSDT1?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDT1 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDT1 = tmp;
                }
            }
        }
        /// <summary>
        /// 终止交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? TRSDT2 { get; set; }
        /// <summary>
        /// 终止交易日期	D, 对应<see cref="TRSDT2"/>
        /// </summary>
        [XmlElement("TRSDT2")]
        public string TRSDT2Str
        {
            get
            {
                return this.TRSDT2?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRSDT2 = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRSDT2 = tmp;
                }
            }
        }
        /// <summary>
        /// 业务编号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 分行号	C(3)	附录A.48招行3位分行
        /// </summary>
        public string BBKNUM { get; set; }
        /// <summary>
        /// 机构号	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 备用字段	C(56)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
