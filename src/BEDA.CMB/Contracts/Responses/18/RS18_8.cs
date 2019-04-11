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
    /// 18.8.查询账单列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS18_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKSWPKGLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKSWPKGLST";
        /// <summary>
        /// 18.8.查询账单列表响应集合
        /// </summary>
        [XmlElement("SWPKGSMRX1")]
        public List<SWPKGSMRX1> List { get; set; }
    }
    /// <summary>
    /// 18.8.查询账单列表响应内容
    /// </summary>
    public class SWPKGSMRX1
    {
        /// <summary>
        /// 电文编号	C(16)
        /// </summary>
        public string SWFNBR { get; set; }
        /// <summary>
        /// 20编号	C(16)
        /// </summary>
        public string FLDN20 { get; set; }
        /// <summary>
        /// 电文类型	C(5)
        /// </summary>
        public string SWFTYP { get; set; }
        /// <summary>
        /// 发报行SWIFT代码	C(11)
        /// </summary>
        public string SNDSCD { get; set; }
        /// <summary>
        /// 接收行SWIFT代码	C(11)
        /// </summary>
        public string RCVSCD { get; set; }
        /// <summary>
        /// 发送日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SNDDTE { get; set; }
        /// <summary>
        /// 发送日期	D, 对应<see cref="SNDDTE"/>
        /// </summary>
        [XmlElement("SNDDTE")]
        public string SNDDTEStr
        {
            get
            {
                return this.SNDDTE?.ToString("yyyyMMdd");
            }
            set
            {
                this.SNDDTE = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SNDDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 接收日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? RCVDTE { get; set; }
        /// <summary>
        /// 接收日期	D, 对应<see cref="RCVDTE"/>
        /// </summary>
        [XmlElement("RCVDTE")]
        public string RCVDTEStr
        {
            get
            {
                return this.RCVDTE?.ToString("yyyyMMdd");
            }
            set
            {
                this.RCVDTE = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCVDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 币种	C(3)	A.47国际业务货币代码表
        /// </summary>
        public string SWFCCY { get; set; }
        /// <summary>
        /// 金额（起始金额）	M
        /// </summary>
        public decimal? SWFAMT { get; set; }
        /// <summary>
        /// 起息日(账单日)	D
        /// </summary>
        [XmlIgnore]
        public DateTime? VLDDTE { get; set; }
        /// <summary>
        /// 起息日(账单日)	D, 对应<see cref="VLDDTE"/>
        /// </summary>
        [XmlElement("VLDDTE")]
        public string VLDDTEStr
        {
            get
            {
                return this.VLDDTE?.ToString("yyyyMMdd");
            }
            set
            {
                this.VLDDTE = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.VLDDTE = tmp;
                }
            }
        }
        /// <summary>
        /// 发报方账号(账户行账号)	C(35)
        /// </summary>
        public string SNDACC { get; set; }
        /// <summary>
        /// 收报方账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 电文类型	C(3)
        /// </summary>
        public string MSGTAG { get; set; }
        /// <summary>
        /// MUR编号	C(16)
        /// </summary>
        public string MURNUM { get; set; }
        /// <summary>
        /// 33B金额	M
        /// </summary>
        public decimal? AMT33B { get; set; }
    }
}
