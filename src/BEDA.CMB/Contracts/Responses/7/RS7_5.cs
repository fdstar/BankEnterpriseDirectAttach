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
    /// 7.5.查询待确认委托贷款业务响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTWAKALN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTWAKALN";
        /// <summary>
        /// 7.5.查询待确认委托贷款业务响应集合
        /// </summary>
        [XmlElement("NTALNLSTZ")]
        public List<NTALNLSTZ> List { get; set; }
    }
    /// <summary>
    /// 7.5.查询待确认委托贷款业务响应内容
    /// </summary>
    public class NTALNLSTZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 贷款业务号	C(10)
        /// </summary>
        public string BUSNUM { get; set; }
        /// <summary>
        /// 操作类型	C(3)	‘LND’：贷款；‘PYO’：还款
        /// </summary>
        public string SLNOPR { get; set; }
        /// <summary>
        /// 分行号	C(2,2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 委托方名称	Z(62)
        /// </summary>
        public string LNRNAM { get; set; }
        /// <summary>
        /// 借款方分行号	C(2,2)
        /// </summary>
        public string BWRBBK { get; set; }
        /// <summary>
        /// 借款方账号	C(35)
        /// </summary>
        public string BWRACC { get; set; }
        /// <summary>
        /// 借款方名称	Z(62)
        /// </summary>
        public string BWRNAM { get; set; }
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
        /// 币种	C(2,2)
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
        /// 贷款用途	C(5)	A.12 贷款用途
        /// </summary>
        public string LONUSG { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 还款日	D   还款
        /// </summary>
        [XmlIgnore]
        public DateTime? PYODAT { get; set; }
        /// <summary>
        /// 还款日	D, 对应<see cref="PYODAT"/>
        /// </summary>
        [XmlElement("PYODAT")]
        public string PYODATStr
        {
            get
            {
                return this.PYODAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PYODAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PYODAT = tmp;
                }
            }
        }
        /// <summary>
        /// 余额	M   还款
        /// </summary>
        public decimal? BLVAMT { get; set; }
        /// <summary>
        /// 利息	M   还款
        /// </summary>
        public decimal? INTAMT { get; set; }
    }
}
