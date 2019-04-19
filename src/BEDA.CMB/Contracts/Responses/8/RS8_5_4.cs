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
    /// 8.5.4.智能定期转活期经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_5_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTATCOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTATCOPR";
        /// <summary>
        /// 8.5.4.智能定期转活期经办响应内容
        /// </summary>
        public NTATCOPRZ1 NTATCOPRZ1 { get; set; }
    }
    /// <summary>
    /// 8.5.4.智能定期转活期经办响应内容
    /// </summary>
    public class NTATCOPRZ1
    {
        /// <summary>
        /// 客户类别	C(1)    C-普通企业客户 O-离岸客户 F-同业客户
        /// </summary>
        public string CTLTYP { get; set; }
        /// <summary>
        /// 存期	C(6)	附录A.8存期代码
        /// </summary>
        public string TERDUM { get; set; }
        /// <summary>
        /// 起息日	D
        /// </summary>
        [XmlIgnore]
        public DateTime INTDAT { get; set; }
        /// <summary>
        /// 起息日	D, 对应<see cref="INTDAT"/>
        /// </summary>
        [XmlElement("INTDAT")]
        public string INTDATStr
        {
            get
            {
                return this.INTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INTDAT = tmp;
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
        /// 计费币种	C(2)
        /// </summary>
        public string FEECCY { get; set; }
        /// <summary>
        /// 费用金额	M
        /// </summary>
        public decimal FEEAMT { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
