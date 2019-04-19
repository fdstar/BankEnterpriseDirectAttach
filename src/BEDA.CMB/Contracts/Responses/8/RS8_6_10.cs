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
    /// 8.6.10.组合存款利息详细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_10 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMAQIT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAQIT";
        /// <summary>
        /// 8.6.10.组合存款利息详细查询响应集合
        /// </summary>
        [XmlElement("NTCMAQITZ1")]
        public List<NTCMAQITZ1> List { get; set; }
    }
    /// <summary>
    /// 8.6.10.组合存款利息详细查询响应内容
    /// </summary>
    public class NTCMAQITZ1
    {
        /// <summary>
        /// 交易日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime STRDAT { get; set; }
        /// <summary>
        /// 交易日期	D, 对应<see cref="STRDAT"/>
        /// </summary>
        [XmlElement("STRDAT")]
        public string STRDATStr
        {
            get
            {
                return this.STRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.STRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string TRXSET { get; set; }
        /// <summary>
        /// 活期户口号	C(35) 
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 定期户口号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 货币号	C(2) 
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇户	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
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
        /// 计息本金	M
        /// </summary>
        public decimal INTAMT { get; set; }
        /// <summary>
        /// 利率	I
        /// </summary>
        public decimal INTRAT { get; set; }
        /// <summary>
        /// 利息金额	M
        /// </summary>
        public decimal INTRST { get; set; }
        /// <summary>
        /// 应税利息	M
        /// </summary>
        public decimal ITXINT { get; set; }
        /// <summary>
        /// 税率   	F(5,2) 
        /// </summary>
        public decimal TAXRAT { get; set; }
        /// <summary>
        /// 利息税金额	M
        /// </summary>
        public decimal ITXAMT { get; set; }
        /// <summary>
        /// 税后利息 	M
        /// </summary>
        public decimal TXDINT { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
