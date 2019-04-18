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
    /// 8.4.12.提前支取通知存款响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_12 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSMAWOP
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMAWOP";
        /// <summary>
        /// 8.4.12.提前支取通知存款响应内容
        /// </summary>
        public NTSMAWOPZ NTSMAWOPZ { get; set; }
    }
    /// <summary>
    /// 8.4.12.提前支取通知存款响应内容
    /// </summary>
    public class NTSMAWOPZ
    {
        /// <summary>
        /// 存期	N(3,0)
        /// </summary>
        public string TERDUM { get; set; }
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
        /// 止息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime EINDAT { get; set; }
        /// <summary>
        /// 止息日	D, 对应<see cref="EINDAT"/>
        /// </summary>
        [XmlElement("EINDAT")]
        public string EINDATStr
        {
            get
            {
                return this.EINDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EINDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 帐户余额	M
        /// </summary>
        public decimal ACTBAL { get; set; }
        /// <summary>
        /// 支取金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal TAXAMT { get; set; }
        /// <summary>
        /// 计费货币号	C(2)
        /// </summary>
        public string FEECCY { get; set; }
        /// <summary>
        /// 应收费用金额	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
