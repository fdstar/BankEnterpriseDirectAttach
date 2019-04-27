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
    /// 25.2.查询待还款信息列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS25_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCDTRPY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCDTRPY";
        /// <summary>
        /// 25.2.查询待还款信息列表响应集合
        /// </summary>
        [XmlElement("NTCDTRPYZ1")]
        public List<NTCDTRPYZ1> List { get; set; }
    }
    /// <summary>
    /// 25.2.查询待还款信息列表响应内容
    /// </summary>
    public class NTCDTRPYZ1
    {
        /// <summary>
        /// 贷款业务号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 额度编号	C(10)
        /// </summary>
        public string CRLNUM { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 放款日	D
        /// </summary>
        [XmlIgnore]
        public DateTime LONDAT { get; set; }
        /// <summary>
        /// 放款日	D, 对应<see cref="LONDAT"/>
        /// </summary>
        [XmlElement("LONDAT")]
        public string LONDATStr
        {
            get
            {
                return this.LONDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LONDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="EXPDAT"/>
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
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 放款金额	M
        /// </summary>
        public decimal LONAMT { get; set; }
        /// <summary>
        /// 利率	I
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 放款用途	C(5)
        /// </summary>
        public string LONUSG { get; set; }
        /// <summary>
        /// 余额	M
        /// </summary>
        public decimal BLVAMT { get; set; }
        /// <summary>
        /// 利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 保留字30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
