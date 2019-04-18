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
    /// 8.3.8.历史委托查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_8 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTHSTQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTHSTQRY";
        /// <summary>
        /// 8.3.8.历史委托查询响应集合
        /// </summary>
        [XmlElement("NTHSTQRYZ")]
        public List<NTHSTQRYZ> List { get; set; }
    }
    /// <summary>
    /// 8.3.8.历史委托查询响应内容
    /// </summary>
    public class NTHSTQRYZ
    {
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
        /// <summary>
        /// 产品简称	Z(22)
        /// </summary>
        public string RIPSNM { get; set; }
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
        /// <summary>
        /// 委托价格	F(11,7)
        /// </summary>
        public decimal ORDPRC { get; set; }
        /// <summary>
        /// 委托份额	M
        /// </summary>
        public decimal ORDQTY { get; set; }
        /// <summary>
        /// 委托金额	M
        /// </summary>
        public decimal ORDAMT { get; set; }
        /// <summary>
        /// 委托类型	C(4)
        /// </summary>
        public string ORDTYP { get; set; }
        /// <summary>
        /// 证券到账日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? RIPCLR { get; set; }
        /// <summary>
        /// 证券到账日期	D, 对应<see cref="RIPCLR"/>
        /// </summary>
        [XmlElement("RIPCLR")]
        public string RIPCLRStr
        {
            get
            {
                return this.RIPCLR?.ToString("yyyyMMdd");
            }
            set
            {
                this.RIPCLR = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RIPCLR = tmp;
                }
            }
        }
        /// <summary>
        /// 资金到账日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? FUNCLR { get; set; }
        /// <summary>
        /// 资金到账日期	D, 对应<see cref="FUNCLR"/>
        /// </summary>
        [XmlElement("FUNCLR")]
        public string FUNCLRStr
        {
            get
            {
                return this.FUNCLR?.ToString("yyyyMMdd");
            }
            set
            {
                this.FUNCLR = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FUNCLR = tmp;
                }
            }
        }
        /// <summary>
        /// 货币代码	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 货币市场	C(1)
        /// </summary>
        public string CCYMKT { get; set; }
        /// <summary>
        /// 费用委托金额	M
        /// </summary>
        public decimal FEEORD { get; set; }
    }
}
